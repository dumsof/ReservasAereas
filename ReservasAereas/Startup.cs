using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReservasAereas.Startup))]
namespace ReservasAereas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
