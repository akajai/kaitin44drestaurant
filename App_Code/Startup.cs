using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kaitin44drestaurant.Startup))]
namespace kaitin44drestaurant
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
