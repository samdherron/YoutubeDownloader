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
        public string Name { get; set; }
        public TimeSpan Length { get; set; }
        public int FileSize { get; set; }
        public string State { get; set; }

        public DateTime DownloadedAt { get; set; }

        public string VideoImagePath { get; set; }
    }
}
