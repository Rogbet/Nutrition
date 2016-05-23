using System.Web;
using System.Web.Optimization;

namespace Nutrition
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jqueryval/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap/bootstrap.js",
                      "~/Scripts/bootstrap/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular/angular.min.js",
                      "~/Scripts/angular/angular-animate.min.js",
                      "~/Scripts/angular/angular-ui-router.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/application").Include(
                      "~/Scripts/app/app.js",
                      "~/Scripts/app/config.js",
                      "~/Scripts/app/route-config.js",
                      "~/Scripts/app/patient/patient.controller.js",
                      "~/Scripts/app/services/service.js"));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                      "~/Scripts/moment/moment.min.js",
                      "~/Scripts/moment/moment-with-locales.min.js",
                      "~/Scripts/moment/angular-moment.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-ui").Include(
                      "~/Scripts/angular-ui/ui-bootstrap-tpls.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      //"~/Content/bootstrap.css",
                      "~/Content/themes/bootstrap.spacelab.min.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/css/font-awesome.css",
                      "~/Content/site.css"));
        }
    }
}
