using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADTaskManager.Startup))]
namespace ADTaskManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
