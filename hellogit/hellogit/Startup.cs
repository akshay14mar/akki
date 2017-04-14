using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hellogit.Startup))]
namespace hellogit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
