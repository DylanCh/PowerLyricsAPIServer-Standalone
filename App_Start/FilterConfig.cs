using System.Web;
using System.Web.Mvc;

namespace PowerLyricsAPIServer_Standalone
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
