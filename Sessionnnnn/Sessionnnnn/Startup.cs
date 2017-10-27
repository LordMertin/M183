using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sessionnnnn.Startup))]
namespace Sessionnnnn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
