using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IICPSES.Startup))]
namespace IICPSES
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
