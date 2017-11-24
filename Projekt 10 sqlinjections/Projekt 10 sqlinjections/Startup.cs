using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_10_sqlinjections.Startup))]
namespace Projekt_10_sqlinjections
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
