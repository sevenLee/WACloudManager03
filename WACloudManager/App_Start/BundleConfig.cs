using System.Web;
using System.Web.Optimization;

namespace WACloudManager
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/bundles/css/fontawesome").Include(
                                  "~/Content/vendor/fontawesome/css/font-awesome.css"));

            bundles.Add(new StyleBundle("~/bundles/css/wafont").Include(
                               "~/Content/vendor/wafont/css/wafont.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/angularLibs").Include(
              "~/Scripts/jquery/dist/jquery.js",

                "~/Scripts/angular.js",
                //"~/Scripts/angular-route.js",
                 "~/Scripts/angular-ui-router.js"
               // "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angularMVC").Include(
                        "~/app/waCloudApp.js",
                        "~/app/sidebarController.js",
                        "~/app/mainController.js",
                        //"~/app/services/domainInfoFactory.js",
                        "~/app/services/waApi.service.js",
                        "~/app/home/homeIndex.js"
//                        "~/app/deviceManagement/deviceManageIndex.js",
//                        "~/app/tagGroup/tagGroupController.js"
                        

                      ));
           


           //BundleTable.EnableOptimizations = false;

           
        }
    }
}