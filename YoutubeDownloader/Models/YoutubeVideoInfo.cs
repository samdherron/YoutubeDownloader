using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Models
{
    public class YoutubeVideoInfo
    {
        private DateTime _downloadedAt;
        public string Name { get; set; }
        public int? Length { get; set; }
        public int FileSize { get; set; }
        public string State { get; set; }

        public DateTime DownloadedAt { get { return _downloadedAt; } set { _downloadedAt =  DateTime.UtcNow; } }

        public string VideoImagePath { get; set; }
    }
}
