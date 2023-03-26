using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication1NetFramework.Startup))]
namespace WebApplication1NetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
