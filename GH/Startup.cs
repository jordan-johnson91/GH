using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GH.Startup))]
namespace GH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
