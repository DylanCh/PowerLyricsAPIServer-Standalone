using PowerLyricsAPIServer_Standalone.Providers;
using RestSharp;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Services;

namespace PowerLyricsAPIServer_Standalone.Controllers
{
    //[WebService]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public Models.RootObject Get()
        {
            string artist = "Ed Sheeran", title = "Thinking Out Loud";
            var client = new RestClient("http://api.musixmatch.com/"
                + "ws/1.1/matcher.lyrics.get?q_track="
                + title.Trim()
                + "&q_artist=" + artist
                + "&apikey="
                + MusixMatch.getAPIKey());

            var request = new RestRequest(
                Method.GET);

           
            //request.AddHeader("Content-Type", "text/plain");

            var response = client.Execute<Models.RootObject>(request).Data;
            //response.ContentType = "application/json";
            
            return response;
        }

       

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
