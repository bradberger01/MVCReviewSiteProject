using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReviewSiteProject2.Startup))]
namespace ReviewSiteProject2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
