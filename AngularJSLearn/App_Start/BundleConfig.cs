using System.Web;
using System.Web.Optimization;

namespace AngularJSLearn
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AngularJSLearn")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                 .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/AngularJSLearn.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                                          "~/Content/site.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
