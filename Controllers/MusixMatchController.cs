using PowerLyricsAPIServer_Standalone.Providers;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PowerLyricsAPIServer_Standalone.Controllers
{
    public class MusixMatchController : Controller
    {
        // GET: MusixMatch
        public ActionResult Index()
        { 
            return View();
        }

        public ContentResult data(string artist,string title) {
            //artist = "Ed Sheeran";
            //title = "Thinking Out Loud";
            var client = new RestClient("http://api.musixmatch.com/"
                + "ws/1.1/matcher.lyrics.get?q_track="
                + title.Trim()
                + "&q_artist=" + artist
                + "&apikey="
                + MusixMatch.getAPIKey());
            var request = new RestRequest(Method.GET);
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            response.ContentType = "application/json";
            return Content(response.Content, "application/json");
        }
    }
}