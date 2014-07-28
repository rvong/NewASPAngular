using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewASPProject.Startup))]
namespace NewASPProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
