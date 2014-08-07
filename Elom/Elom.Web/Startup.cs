using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Elom.Web.Startup))]
namespace Elom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
