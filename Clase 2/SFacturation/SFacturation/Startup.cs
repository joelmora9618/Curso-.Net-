using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SFacturation.Startup))]
namespace SFacturation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
