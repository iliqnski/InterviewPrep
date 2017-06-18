using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PracticalIoC.Startup))]
namespace PracticalIoC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
