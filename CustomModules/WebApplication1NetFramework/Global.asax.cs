using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1NetFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Console.WriteLine("Application_BeginRequest");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            HttpContext ctx = app.Context;
            var authenticated = ctx.Request.IsAuthenticated;
            Console.WriteLine("Application_AuthenticateRequest authenticated: " + authenticated);
        }

        protected void Applcation_PreSendRequestHeaders(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            HttpContext ctx = app.Context;
            var authenticated = ctx.Request.IsAuthenticated;
            var responseStatus = ctx.Response.StatusCode;
            Console.WriteLine("Applcation_PreSendRequestHeaders status: " + responseStatus);
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            HttpContext ctx = app.Context;
            var responseStatus = ctx.Response.StatusCode;
            if (responseStatus == 302)  //do some checking here
            {
                ctx.Response.StatusCode = 429;
                ctx.Response.Write("Too many request");
                ctx.Response.TrySkipIisCustomErrors = true;
            }
            Console.WriteLine("Applcation_PreSendRequestHeaders status: " + responseStatus);

        }

        protected void Application_PreSendContent(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            HttpContext ctx = app.Context;
        }

        protected void Application_PostRequestHandlerExecute(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            HttpContext ctx = app.Context;
        }
    }
}
