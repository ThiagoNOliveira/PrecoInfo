using System.Web;
using System.Web.Optimization;

namespace PrecoInfo.UI
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Libraries").Include(
                "~/Scripts/jquery.js",
                 "~/Scripts/bootstrap-min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/themes/bootstrap/bootstrap.css",
                "~/Content/themes/bootstrap/bootstrap-responsive.css",
                "~/Content/font-awesome.css",
                "~/Content/site.css"));
        }
    }
}