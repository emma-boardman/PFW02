using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmmasCauseShop.Startup))]
namespace EmmasCauseShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
