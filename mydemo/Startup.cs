using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mydemo.Startup))]
namespace mydemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
