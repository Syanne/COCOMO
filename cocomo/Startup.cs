using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cocomo.Startup))]
namespace cocomo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
