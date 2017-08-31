using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(toraProject.Startup))]
namespace toraProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
