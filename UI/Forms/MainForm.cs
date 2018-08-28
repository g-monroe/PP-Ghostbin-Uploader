using System.Diagnostics;
using System.Windows.Forms;    
using GhostBinUploaderClass.Core.Providers;

namespace GhostBinUploaderClass.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void bUpload_Click(object sender, System.EventArgs e)
        {
            using (var provider = new GhostBinProvider())
            {
                var response = await provider.UploadText(tbTitle.Text, rtbText.Text, tbPass.Text);

                var message = response.Success ? response.PasteUri.ToString() : "Upload Failure";
                tbMessage.Text = message;
            }
        }

        private void tbMessage_DoubleClick(object sender, System.EventArgs e)
        {
            if (!tbMessage.Text.EndsWith("Failure"))
                Process.Start(tbMessage.Text);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}