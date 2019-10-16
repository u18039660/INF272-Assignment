using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobTinder.Startup))]
namespace JobTinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
