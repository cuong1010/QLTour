using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTour.Startup))]
namespace WebTour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
