using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IRProject.Startup))]
namespace IRProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
