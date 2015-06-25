using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetailNews.Startup))]
namespace RetailNews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
