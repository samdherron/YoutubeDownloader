using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VideoLibrary;
using YoutubeDownloader.Models;
using MediaToolkit.Model;
using MediaToolkit;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using YoutubeDownloader.Helpers;

namespace YoutubeDownloader.Services
{
    public class DownloadingService
    {
        public static DownloadManager downloadManager;
        public List<YoutubeVideoInfo> currentVideos = new List<YoutubeVideoInfo>();

        public DownloadingService()
        {
            downloadManager = new DownloadManager();
        }

        public async Task ProcessDownloadRequestAsync(string uri)
        {
            
            YouTubeVideo video = null;
            using (var cli = Client.For(new YouTube()))
            {
                List<YouTubeVideo> videos = cli.GetAllVideosAsync(uri).Result.ToList();

                video = videos.Where(x => x.AudioBitrate >= videos.Min(z => z.AudioBitrate)).FirstOrDefault();

                YoutubeVideoInfo newVideoInfo = new YoutubeVideoInfo();

                string safeTitle = ValidationHelper.SafeVideoTitle(video.Info.Title);

                var videoImagePath = GetVideoImage(uri, safeTitle);

                if (video != null)
                {
                    newVideoInfo.Name = safeTitle;
                    newVideoInfo.Length = video.Info.LengthSeconds;
                    newVideoInfo.VideoImagePath = videoImagePath;
                    newVideoInfo.DownloadedAt = DateTime.Now;

                    currentVideos.Add(newVideoInfo);

                    var mp3FilePath = await DownloadVideoAsync(video, videoImagePath);

                    if (MainForm.AutoPlay)
                    {
                        Process.Start(mp3FilePath);
                    }

                    downloadManager.UpdateJsonDownloadRecords(currentVideos);
                }
            }
        }

        private async Task<string> DownloadVideoAsync(YouTubeVideo video, string videoImagePath)
        {
            byte[] videoBytes = await video.GetBytesAsync();

            string safeFileName = ValidationHelper.RemoveWhitespace(video.Title);

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "YoutubeDownloader");

            string filePath = Path.Combine(folderPath, safeFileName + video.FileExtension);

            string mp3FilePath = filePath.Replace(".mp4", ".mp3");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            if (File.Exists(mp3FilePath))
            {
                File.Delete(mp3FilePath);
            }

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            File.WriteAllBytes(filePath, videoBytes);

            GenerateMp3File(filePath, mp3FilePath);

            AddImageToFile(mp3FilePath, videoImagePath);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return mp3FilePath;

        }

        private void AddImageToFile(string filePath, string videoImagePath)
        {
            var mp3File = TagLib.File.Create(filePath);

            mp3File.Tag.Pictures = new TagLib.IPicture[]
            {
                new TagLib.Picture(new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter().ConvertTo(System.Drawing.Image.FromFile(videoImagePath), typeof(byte[]))))
                {
                    Type = TagLib.PictureType.FrontCover,
                    Description = "Cover",
                    MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg
                }
            };

            mp3File.Save();
        }

        private void GenerateMp3File(string safeFileName, string mp3FilePath)
        {

            var inputFile = new MediaFile { Filename = safeFileName };
            var outputFile = new MediaFile { Filename = mp3FilePath };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }

        }

        private string GetVideoImage(string uri, string videoTitle)
        {
            string videoID = uri.Substring(uri.IndexOf("?v=") + 3);

            int index = videoID.IndexOf("&");
            if (index >= 0)
                videoID = videoID.Substring(0, index);

            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "YoutubeDownloader", "Images");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string imageUri = "https://img.youtube.com/vi/" + videoID + "/maxresdefault.jpg";
            string backupImageUri = "https://img.youtube.com/vi/" + videoID + "/hqdefault.jpg";
            string imagePath = Path.Combine(folderPath, videoTitle + ".jpg");

            using (WebClient webClient = new WebClient())
            {
                byte[] data = null;
                try
                {
                    data = webClient.DownloadData(imageUri);
                } catch
                {
                    data = webClient.DownloadData(backupImageUri);
                }

                using (MemoryStream mem = new MemoryStream(data))
                {
                    using (var videoImage = Image.FromStream(mem))
                    {
                        videoImage.Save(imagePath, ImageFormat.Jpeg);
                    }
                }

            }

            return imagePath;
        }
    }
}
