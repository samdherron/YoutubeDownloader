using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Models;

namespace YoutubeDownloader.Helpers
{
    public class DownloadManager
    {
        public string AppdataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "YoutubeDownloader");

        public void UpdateJsonDownloadRecords(List<YoutubeVideoInfo> currentVideos)
        {
            try
            {
                string filePath = Path.Combine(AppdataFolder, "DownloadRecords.json");

                if (!Directory.Exists(AppdataFolder))
                {
                    Directory.CreateDirectory(AppdataFolder);
                }

                if (!File.Exists(filePath))
                {
                    File.Create(filePath);
                }

                var currentRecords = GetJsonDownloadRecords();

                if (currentRecords == null)
                {
                    currentRecords = new List<YoutubeVideoInfo>();
                }

                foreach(YoutubeVideoInfo record in currentVideos)
                {
                    if (currentRecords.Contains(record))
                    {
                        currentRecords.Remove(record);
                    }

                    currentRecords.Add(record);
                }

                File.Delete(filePath);

                var jsonObject = JsonConvert.SerializeObject(currentRecords);

                File.AppendAllText(filePath, jsonObject);

                currentVideos.Clear();
            
            } 
            catch
            {
                MessageBox.Show("Couldn't update records.");
            }
        }


        

        public List<YoutubeVideoInfo> GetJsonDownloadRecords()
        {
            string filePath = Path.Combine(AppdataFolder, "DownloadRecords.json");
            List<YoutubeVideoInfo> downloadRecords = new List<YoutubeVideoInfo>();

            if (File.Exists(filePath))
            {
                downloadRecords = JsonConvert.DeserializeObject<List<YoutubeVideoInfo>>(File.ReadAllText(filePath));
            }

            if (downloadRecords != null)
            {
                downloadRecords = downloadRecords.OrderByDescending(x => x.DownloadedAt).ToList();
            }

            return downloadRecords;
        }
    }
}
