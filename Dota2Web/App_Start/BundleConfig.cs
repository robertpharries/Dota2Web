using System.Web;
using System.Web.Optimization;

namespace Dota2Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/Dota2Web")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/Dota2Web.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
