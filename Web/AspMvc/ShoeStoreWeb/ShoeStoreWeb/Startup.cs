using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoeStoreWeb.Startup))]
namespace ShoeStoreWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
