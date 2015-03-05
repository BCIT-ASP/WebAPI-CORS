using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CorsStudentClient.Startup))]
namespace CorsStudentClient
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
