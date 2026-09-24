using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutorial_2_2.Startup))]
namespace Tutorial_2_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
