using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EnterSiteDemo.Startup))]
namespace EnterSiteDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
