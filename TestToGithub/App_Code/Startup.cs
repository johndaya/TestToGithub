using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestToGithub.Startup))]
namespace TestToGithub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
