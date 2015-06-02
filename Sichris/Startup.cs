using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sichris.Startup))]
namespace Sichris
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
