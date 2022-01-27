using System.Web;
using System.Web.Optimization;

namespace MVRWebsite_Unibit_5sem_MWT_MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Styles/Bootstrap/bootstrap.css",
                      "~/Content/Styles/Yamm/yamm.css",
                      "~/Content/Styles/MVR_Styles/colors.css",
                      "~/Content/Styles/MVR_Styles/utils.css",
                      "~/Content/Styles/MVR_Styles/navbar.css",
                      "~/Content/Styles/MVR_Styles/most-top-bar.css",
                      "~/Content/Styles/MVR_Styles/header.css",
                      "~/Content/Styles/MVR_Styles/footer.css",
                      "~/Content/Styles/MVR_Styles/mvr-card.css"
                      ));
        }
    }
}
