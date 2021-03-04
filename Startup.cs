using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProject_Raihan.Startup))]
namespace MvcProject_Raihan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
