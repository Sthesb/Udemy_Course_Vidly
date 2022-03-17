using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyVidly.Startup))]
namespace UdemyVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
