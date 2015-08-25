﻿using System.Web.Optimization;

namespace GalleryMVC_With_Auth
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/magic").Include(
                "~/Scripts/transp_menu_magic.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/galmagic").Include(
                "~/Content/blueimp-gallery2/js/blueimp-gallery.min.js",
                "~/Scripts/BlueimpGal.js",
                "~/Scripts/jquery.lazyload.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/hover_effects/component.css",
                "~/Content/hover_effects/normalize.css",
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/transp_menu.css",
                "~/Content/sticky-footer.css",
                "~/Content/blueimp-gallery2/css/blueimp-gallery.min.css",
                "~/Content/search.css"));
        }
    }
}