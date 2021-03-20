using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FiltersMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/main")
                .Include("~/Content/bootstrap.css"));

            bundles.Add(new ScriptBundle("~/script/custom")
                .Include("~/Scripts/jquery-3.0.0.js")
                .Include("~/Scripts/popper.js")
                .Include("~/Scripts/jbootstrap.js")
                .Include("~/Scripts/workModule.js")
                );
        }
    }
}