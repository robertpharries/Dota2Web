using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dota2Web.Startup))]
namespace Dota2Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
