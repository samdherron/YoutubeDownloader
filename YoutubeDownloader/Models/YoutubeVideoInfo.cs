using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Models
{
    public class YoutubeVideoInfo
    {
        public string Name { get; set; }
        public int? Length { get; set; }
        public int FileSize { get; set; }
        public string State { get; set; }
    }
}
