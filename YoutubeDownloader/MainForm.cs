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
using System.Threading;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        public DownloadingService downloadService;
        public DownloadManager downloadManager;
        public List<YoutubeVideoInfo> currentRecords;
        public static bool AutoPlay = false;

        public MainForm()
        {
            InitializeComponent();
            
            downloadService = new DownloadingService();
            downloadManager = new DownloadManager();

            sfListView1.DisplayMember = "Name";
            sfListView1.ValueMember = "Name";
            sfListView1.DrawItem += new EventHandler<Syncfusion.WinForms.ListView.Events.DrawItemEventArgs>(SfListView1_DrawImages);
            currentRecords = downloadManager.GetJsonDownloadRecords();
            sfListView1.DataSource = currentRecords;
        }

        private void SfListView1_DrawImages(object sender, Syncfusion.WinForms.ListView.Events.DrawItemEventArgs e)
        {
            YoutubeVideoInfo video = currentRecords.Where(x => x.Name == e.Text).FirstOrDefault();
            Image videoImage = Image.FromFile(video.VideoImagePath);
            videoImage = resizeImage(videoImage, new Size(192, 96));
            e.Image = videoImage;
            e.ImageAlignment = ContentAlignment.MiddleLeft;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }



        private async void sfButton1_Click(object sender, EventArgs e)
        {
            if (txtUrl.TextLength > 0 && Uri.IsWellFormedUriString(txtUrl.Text, UriKind.RelativeOrAbsolute))
            {
                Cursor.Current = Cursors.WaitCursor;
                await Task.Run(async () => {
                    await downloadService.ProcessDownloadRequestAsync(txtUrl.Text);
                    });
                //await downloadService.ProcessDownloadRequestAsync(txtUrl.Text);
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
            currentRecords = currentRecords.OrderByDescending(x => x.DownloadedAt).ToList();
            sfListView1.DataSource = currentRecords;
            sfListView1.View.Refresh();
        }

        private void OpenUponDownloadSetting_CheckStateChanged(object sender, EventArgs e)
        {
            AutoPlay = OpenUponDownloadSetting.Checked;
        }
    }
}
