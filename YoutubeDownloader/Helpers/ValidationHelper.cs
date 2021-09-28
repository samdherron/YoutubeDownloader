using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeDownloader.Helpers
{
    public static class ValidationHelper
    {
        public static string SafeVideoTitle(string title)
        {
            string safeTitle = title;

            if (!string.IsNullOrEmpty(safeTitle))
            {
                char[] charArray = safeTitle.ToCharArray();

                charArray = Array.FindAll<char>(charArray, (c => (char.IsLetterOrDigit(c)
                                                  || char.IsWhiteSpace(c))));
                safeTitle = new string(charArray);
            }


            return safeTitle;

        }
    }
}
