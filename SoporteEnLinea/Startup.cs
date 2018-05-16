using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoporteEnLinea.Startup))]
namespace SoporteEnLinea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
