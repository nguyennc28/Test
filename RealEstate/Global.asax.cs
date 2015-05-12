using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using RealEstate;
using RealEstate.Common;

namespace RealEstate
{
    public class Global : HttpApplication
    {
        public static CookieClass Cookie = new CookieClass();
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
        public static string GetLang()
        {
            return StringClass.Check(Cookie.GetCookie("Lang")) ? Cookie.GetCookie("Lang") : "";
        }
    }
}
