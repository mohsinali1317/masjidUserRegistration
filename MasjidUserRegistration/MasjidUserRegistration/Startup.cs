using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasjidUserRegistration.Startup))]
namespace MasjidUserRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
