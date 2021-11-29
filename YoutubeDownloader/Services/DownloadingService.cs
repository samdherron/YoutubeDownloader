using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeDownloader.Models;
using MediaToolkit.Model;
using MediaToolkit;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;
using YoutubeDownloader.Helpers;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;
using System.Net.Http;

namespace YoutubeDownloader.Services
{
    public class DownloadingService
    {
        public static DownloadManager downloadManager;
        public List<YoutubeVideoInfo> currentVideos = new List<YoutubeVideoInfo>();
        public delegate void DownloadCompleteNotify();
        public event EventHandler DownloadedCompleted;
        public Progress<double> ProgressHandler;


        public DownloadingService()
        {
            downloadManager = new DownloadManager();
            ProgressHandler = new Progress<double>();
        }

        public async Task ProcessDownloadRequestAsync(string uri)
        {

            var youtube = new YoutubeClient();

            string validatedUri = ValidationHelper.RemovePlaylistIdentifier(uri);

            var videoInfo = await youtube.Videos.GetAsync(validatedUri);

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoInfo.Id);

            var streamInfo = streamManifest.GetAudioOnlyStreams().Where(x => x.Container.Name == "mp4").FirstOrDefault();

                YoutubeVideoInfo newVideoInfo = new YoutubeVideoInfo();

                string safeTitle = ValidationHelper.SafeVideoTitle(videoInfo.Title);

                var videoImagePath = GetVideoImage(uri, safeTitle, videoInfo.Id);

                if (streamInfo != null)
                {
                    newVideoInfo.Name = safeTitle;
                    newVideoInfo.Length = videoInfo.Duration.Value;
                    newVideoInfo.VideoImagePath = videoImagePath;
                    newVideoInfo.DownloadedAt = DateTime.Now;

                    currentVideos.Add(newVideoInfo);


                string safeFileName = ValidationHelper.RemoveWhitespace(videoInfo.Title);

                string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "YoutubeDownloader");

                string filePath = Path.Combine(folderPath, safeFileName + "." + streamInfo.Container.Name);

                await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, ProgressHandler);

                var mp3FilePath = ConvertToMp3(filePath, videoImagePath);

                if (MainForm.AutoPlay)
                    {
                        Process.Start(mp3FilePath);
                    }

                    downloadManager.UpdateJsonDownloadRecords(currentVideos);
                }
        }

        private string GetIdString(string uri)
        {
            int index = 0;
            if (uri.Contains("youtu.be")) 
            {
                index = uri.IndexOf(".be/");
            } else if (uri.Contains("?v="))
            {
                index = uri.IndexOf("h?v=");
            }

            return uri.Substring(index + 4);
        }

       
        public string ConvertToMp3(string filePath, string videoImagePath) { 
            string mp3FilePath = filePath.Replace(".mp4", ".mp3");


            if (File.Exists(mp3FilePath))
            {
                File.Delete(mp3FilePath);
            }

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

        private string GetVideoImage(string uri, string videoTitle, string videoId)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "YoutubeDownloader", "Images");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string imageUri = "https://img.youtube.com/vi/" + videoId + "/maxresdefault.jpg";
            string backupImageUri = "https://img.youtube.com/vi/" + videoId + "/hqdefault.jpg";
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
