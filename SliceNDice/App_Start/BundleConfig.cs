using System.Web;
using System.Web.Optimization;

namespace SliceNDice
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                "~/Scripts/knockout-{version}.debug.js"));

            bundles.Add(new ScriptBundle("~/bundles/linq").Include(
               "~/Scripts/linq.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
               "~/Scripts/toastr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootswatch.cosmo.css"));


            bundles.Add(new StyleBundle("~/Content/toastr").Include(
               "~/Content/toastr.css"));
        }
    }
}
