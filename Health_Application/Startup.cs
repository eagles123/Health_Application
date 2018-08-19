using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Health_Application.Startup))]
namespace Health_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
