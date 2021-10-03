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
using Syncfusion.WinForms.Theme;
using Syncfusion.Windows.Forms;
using System.IO;

namespace YoutubeDownloader
{
    public partial class MainForm : Form
    {
        public DownloadingService downloadService;
        public DownloadManager downloadManager;
        public List<YoutubeVideoInfo> currentRecords;
        public static bool AutoPlay = false;
        public static string MusicDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "YoutubeDownloader");

        public MainForm()
        {
            FontHelper.CanOverrideFontFamily = true;
            FontHelper.FontFamily = new FontFamily("Nirmala UI");

            InitializeComponent();

            sfSkinManager1.Controls = this;
            sfSkinManager1.VisualTheme = VisualTheme.Office2016Black;

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

        private void SfListView1_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = (YoutubeVideoInfo) sfListView1.SelectedItem;
            var safeName = ValidationHelper.RemoveWhitespace(selectedItem.Name);

            downloadManager.PlaySongFromListview(safeName, MusicDirectory, selectedItem);
        }



        private async void metroButton1_Click(object sender, EventArgs e)
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

        private void AutoPlaySetting_CheckStateChanged(object sender, EventArgs e)
        {
            AutoPlay = AutoPlaySetting.Checked;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Enables dragging since the border is set to none
        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
