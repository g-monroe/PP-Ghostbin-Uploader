using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace GhostBinUploaderClass.Core.Models
{
    public class UploadTextResponse
    {
        public bool Success { get; }

        public Uri PasteUri { get; }

        public UploadTextResponse(HttpResponseMessage response, Uri baseAddress)
        {                       
            var path = response.Headers.Location;
            var match = Regex.Match(path.ToString(), "/paste/(\\w+)");
            if (!match.Success)
            {
                Success = false;
                return;   
            }

            Success = true;
            PasteUri = new Uri($"{baseAddress}paste/{match.Groups[1].Value}");         
        }
    }
}