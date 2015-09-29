using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SjavarBanki.Startup))]
namespace SjavarBanki
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
