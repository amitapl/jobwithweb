using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobWithWeb.Startup))]
namespace JobWithWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
