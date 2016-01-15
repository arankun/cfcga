using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cfcga.web.Startup))]
namespace cfcga.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
