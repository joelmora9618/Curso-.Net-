using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemFacturation.Startup))]
namespace SistemFacturation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
