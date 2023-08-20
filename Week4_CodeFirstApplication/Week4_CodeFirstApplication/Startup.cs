using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week4_CodeFirstApplication.Startup))]
namespace Week4_CodeFirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
