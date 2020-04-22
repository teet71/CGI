using System;
using System.Collections.Generic;
using System.Web.Optimization;
using System.Linq;
using System.Web;

namespace CGI_filmid.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Angular")
                .Include(
                "~/bundles/AngularOutput/inline.*",
                "~/bundles/AngularOutput/polyfills.*",
                "~/bundles/AngularOutput/vendor.*",
                "~/bundles/AngularOutput/runtime.*",
                "~/bundles/AngularOutput/main.*"));
            bundles.Add(new StyleBundle("~/Content/Angular")
                .Include("~/bundles/AngularOutput/styles.*"));
        }
    }
}