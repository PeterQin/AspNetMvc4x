using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1NetFramework.Modules
{
    public class CustomHTTPModule : IHttpModule
    {
        public CustomHTTPModule()
        {
            // Class constructor.
        }

        // Classes that inherit IHttpModule 
        // must implement the Init and Dispose methods.
        public void Init(HttpApplication app)
        {

            app.AcquireRequestState += new EventHandler(app_AcquireRequestState);
            app.PostAcquireRequestState += new EventHandler(app_PostAcquireRequestState);
            app.AuthenticateRequest += new EventHandler(app_AuthenticateRequest);
        }

        public void Dispose()
        {
            // Add code to clean up the
            // instance variables of a module.
        }

        // Define a custom AcquireRequestState event handler.
        public void app_AcquireRequestState(object o, EventArgs ea)
        {
            HttpApplication httpApp = (HttpApplication)o;
            HttpContext ctx = HttpContext.Current;
            //ctx.Response.Write(" Executing AcquireRequestState ");
        }

        // Define a custom PostAcquireRequestState event handler.
        public void app_PostAcquireRequestState(object o, EventArgs ea)
        {
            HttpApplication httpApp = (HttpApplication)o;
            HttpContext ctx = HttpContext.Current;
            //ctx.Response.Write(" Executing PostAcquireRequestState ");
        }

        public void app_AuthenticateRequest(object o, EventArgs ea)
        {
            HttpApplication httpApp = (HttpApplication)o;
            HttpContext ctx = HttpContext.Current;
            //ctx.Response.StatusCode = 429;
        }
    }

}