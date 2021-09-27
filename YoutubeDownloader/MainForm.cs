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
using YoutubeDownloader.Models;
using YoutubeDownloader.Services;
using YoutubeDownloader.Helpers;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        public DownloadingService downloadService;
        public DownloadManager downloadManager;
        public List<YoutubeVideoInfo> currentRecords;

        public MainForm()
        {
            InitializeComponent();
            downloadService = new DownloadingService();
            downloadManager = new DownloadManager();
            currentRecords = downloadManager.GetJsonDownloadRecords();
            listBox1.DataSource = currentRecords;
            listBox1.Refresh();
      
        }

        private async void sfButton1_Click(object sender, EventArgs e)
        {
            if (txtUrl.TextLength > 0 && Uri.IsWellFormedUriString(txtUrl.Text, UriKind.RelativeOrAbsolute))
            {
                Cursor.Current = Cursors.WaitCursor;
                await downloadService.ProcessDownloadRequestAsync(txtUrl.Text);
                Cursor.Current = Cursors.Default;
                UpdateListViewRecords();
              
            } else
            {
                MessageBox.Show("URL is invalid. Please try again...");
            }
        }

        private async void UpdateListViewRecords()
        {
            currentRecords = downloadManager.GetJsonDownloadRecords();      
        }
    }
}
