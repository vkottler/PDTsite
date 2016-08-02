using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PDTSite.Startup))]
namespace PDTSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
