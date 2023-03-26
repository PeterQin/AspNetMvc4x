using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1NetFramework.Handlers
{
    public class AppShutDownHandler : IHttpHandler
    {
        #region Custome HTTPHandler   

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.  
            // Usually this would be false in case you have some state information preserved per request.  
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.StatusCode = 503;
            //context.Response.Write("<h1 style='Color:blue; font-                                       size:15px;'>Our website is under maintainace. Please try after some time</h1>");
            //context.Response.End();
        }

        #endregion
    }
}