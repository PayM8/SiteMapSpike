using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteMapSpike.Startup))]
namespace SiteMapSpike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
