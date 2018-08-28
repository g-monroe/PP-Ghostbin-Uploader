using System;
using System.Collections.Generic;    
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using GhostBinUploaderClass.Core.Models;

namespace GhostBinUploaderClass.Core.Providers
{
    public class GhostBinProvider : IDisposable
    {
        private readonly HttpClient _client;

        public GhostBinProvider()
        {
            var handler = new HttpClientHandler
            {
                AllowAutoRedirect = false,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            _client = new HttpClient(handler);
            _client.BaseAddress = new Uri("https://ghostbin.com");

            _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml+xml,application/xml");
            _client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36");
        }

        public async Task<UploadTextResponse> UploadText(string title, string text, string password)
        {
            if (string.IsNullOrWhiteSpace(title))
                title = "Title";

            if (string.IsNullOrWhiteSpace(text))
                throw new ArgumentNullException(nameof(text));

            if (string.IsNullOrWhiteSpace(password))
                password = string.Empty;

            // Set the authentication cookie so GhostBin can verify that we've been on the homepage once.
            await _client.GetAsync(_client.BaseAddress);

            var request = new HttpRequestMessage(HttpMethod.Post, "/paste/new")
            {
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    {"lang", "text" }, 
                    {"text", text },   
                    {"expire", "-1" },  
                    {"password", password },
                    {"title", title },
                })
            };

            // This method retrives the location header and redirects us to that page. 
            // Since we've set AllowAutoRedirect to false on L18, it doesn't redirect 
            // us and instead handles just the response. 
            var response = await _client.SendAsync(request);
            return new UploadTextResponse(response, _client.BaseAddress);
        }

        public void Dispose()
        {
            _client.Dispose();
        }
    }
}