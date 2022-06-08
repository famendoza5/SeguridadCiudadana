using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeguridadCiudadana.Startup))]
namespace SeguridadCiudadana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
