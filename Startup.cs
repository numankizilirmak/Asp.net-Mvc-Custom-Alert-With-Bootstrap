using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcCustomAlertWithBootstrap.Startup))]
namespace MvcCustomAlertWithBootstrap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
