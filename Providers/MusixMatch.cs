using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace PowerLyricsAPIServer_Standalone.Providers
{
    public static class MusixMatch
    {
        private static string APIKEY = "";
        public static string getAPIKey() {
            return new StringBuilder(APIKEY).ToString();
        }
    }
}