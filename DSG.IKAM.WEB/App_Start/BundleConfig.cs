using DSG.IKAM.WEB.Utilities;
using System.Web;
using System.Web.Optimization;

namespace DSG.IKAM.WEB
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //css
            bundles.AddCss();
            bundles.UseBoostrap();
            //fonts
            bundles.AddNucleoIcons();
            bundles.AddFontAwesomeIcons();

            //js
            //bundles.UseBoostrap();
            //bundles.UseJquery();
            //bundles.UseModernizr();
            bundles.UseCoreJS();
            bundles.UseKanbanJS();
            //img


        }

        

    }

}
