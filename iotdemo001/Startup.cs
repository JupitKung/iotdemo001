using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iotdemo001.Startup))]
namespace iotdemo001
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
