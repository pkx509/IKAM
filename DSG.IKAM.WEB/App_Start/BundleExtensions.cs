using DSG.IKAM.WEB.Utilities;
using System.Web.Optimization;

namespace DSG.IKAM.WEB
{
    internal static class BundleExtensions
    {
        public static void AddCss(this BundleCollection bundles)
        {
            /*
            var css = new StyleBundle("~/Assets/css");
            css.Orderer = new AsIsBundleOrderer();
            css
                .Include("~/Assets/bootstrap.min.css")
                .Include("~/Assets/site.css")
                ;
            bundles.Add(css);
            */
        }
        public static void UseBoostrap(this BundleCollection bundles)
        {
            var css = new StyleBundle("~/assets/css/bootstrap");
            css.Orderer = new AsIsBundleOrderer();
            css
                .Include("~/Assets/css/soft-ui-dashboard.min.css")
                .Include("~/Assets/css/nucleo-icons.css")
                .Include("~/Assets/css/nucleo-nucleo-svg.css")
                ;
            bundles.Add(css);
        }
        public static void UseJquery(this BundleCollection bundles)
        {
            var js = new ScriptBundle("~/Assets/js/jquery");
            js.Orderer = new AsIsBundleOrderer();
            js
                .Include("~/Assets/js/plugins/jquery/jquery-{version}.js")
                .Include("~/Assets/js/plugins/jquery/jquery.validate*")
                ;
            bundles.Add(js);
        }
        public static void UseModernizr(this BundleCollection bundles)
        {
            var js = new ScriptBundle("~/Assets/js/modernizr");
            js.Orderer = new AsIsBundleOrderer();
            js
                .Include("~/Assets/js/plugins/modernizr/modernizr-*")
                ;
            bundles.Add(js);
        }

        public static void AddNucleoIcons(this BundleCollection bundles)
        {
            var css = new StyleBundle("~/Assets/css/nucleo-icons");
            css.Orderer = new AsIsBundleOrderer();
            css
                .Include("~/Assets/css/nucleo-icons.css")
                .Include("~/Assets/css/nucleo-svg.css")
                ;
            bundles.Add(css);
        }
        public static void AddFontAwesomeIcons(this BundleCollection bundles)
        {
            var js = new ScriptBundle("~/Assets/js/font-awesome");
            js.Orderer = new AsIsBundleOrderer();
            js.Include("~/Assets/js/plugins/font-awesome-kit.min.js");
            bundles.Add(js);

            var css = new StyleBundle("~/Assets/css/svg");
            css.Orderer = new AsIsBundleOrderer();
            css.Include("~/Assets/css/nucleo-svg.css");
            bundles.Add(css);

        }

        public static void UseCoreJS(this BundleCollection bundles)
        {
            var js = new ScriptBundle("~/Assets/js/core");
            js.Orderer = new AsIsBundleOrderer();
            js
                .Include("~/Assets/js/core/popper.min.js")
                //.Include("~/Assets/js/core/bootstrap.min.js")
                //.Include("~/Assets/js/core/bootstrap.bundle.min.js")
                .Include("~/Assets/js/plugins/perfect-scrollbar.min.js")
                .Include("~/Assets/js/plugins/smooth-scrollbar.min.js")
                ;
            bundles.Add(js);
        }
        
        public static void UseKanbanJS(this BundleCollection bundles)
        {
            var js = new ScriptBundle("~/Assets/js/jkanban");
            js.Orderer = new AsIsBundleOrderer();
            js
                .Include("~/Assets/js/plugins/dragula/dragula.min.js")
                .Include("~/Assets/js/plugins/jkanban/jkanban.min.js")
                ;
            bundles.Add(js);
        }
    
    }
}