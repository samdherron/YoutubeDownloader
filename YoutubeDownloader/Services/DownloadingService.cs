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

namespace YoutubeDownloader.Services
{
    public class DownloadingService
    {

        public List<YoutubeVideoInfo> currentVideos = new List<YoutubeVideoInfo>();

        public async Task ProcessDownloadRequestAsync(string uri)
        {
            YouTubeVideo video;
            using (var cli = Client.For(new YouTube()))
            {
                List<YouTubeVideo> videos = cli.GetAllVideosAsync(uri).Result.ToList();
                //video = videos.Where(x => x.Resolution >= 720 && x.AudioBitrate != -1).FirstOrDefault();
                video = videos.Where(x => x.AudioBitrate >= videos.Min(z => z.AudioBitrate) && x.Resolution != -1).FirstOrDefault();

                YoutubeVideoInfo newVideoInfo = new YoutubeVideoInfo();

                if (video != null)
                {
                    newVideoInfo.Name = video.Info.Title;
                    newVideoInfo.Length = video.Info.LengthSeconds;

                    currentVideos.Add(newVideoInfo);

                    await DownloadVideoAndPlayAsync(video);
                }
            }
        }

        private async Task DownloadVideoAndPlayAsync(YouTubeVideo video)
        {
            byte[] videoBytes = await video.GetBytesAsync();

            //Stream videoStream = await video.StreamAsync();

            string safeFileName = new string(video.Title.Where(c => char.IsLetterOrDigit(c)).ToArray());



            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), safeFileName + video.FileExtension);
            string mp3FilePath = filePath.Replace(".mp4", ".mp3");

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            if (File.Exists(mp3FilePath))
            {
                File.Delete(mp3FilePath);
            }

            //using (FileStream f = new FileStream(filePath, FileMode.Create))
            //{
            //    videoStream.CopyTo(f);
            //}

            File.WriteAllBytes(filePath, videoBytes);

            GenerateMp3File(filePath, mp3FilePath);

            Process.Start(mp3FilePath);

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
    }
}
