using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Services;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        DownloadingService downloadService;
        public MainForm()
        {
            InitializeComponent();
            downloadService = new DownloadingService();
      
        }

        private async void sfButton1_Click(object sender, EventArgs e)
        {
            if (txtUrl.TextLength > 0 && Uri.IsWellFormedUriString(txtUrl.Text, UriKind.RelativeOrAbsolute))
            {
                Cursor.Current = Cursors.WaitCursor;
                await downloadService.ProcessDownloadRequestAsync(txtUrl.Text);
                Cursor.Current = Cursors.Default;
              
            } else
            {
                MessageBox.Show("URL is invalid. Please try again...");
            }
        }
    }
}
