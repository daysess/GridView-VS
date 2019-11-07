using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WS_GridView.Startup))]
namespace WS_GridView
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
