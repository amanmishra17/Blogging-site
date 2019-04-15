using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Blog_site.Startup))]
namespace Blog_site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
