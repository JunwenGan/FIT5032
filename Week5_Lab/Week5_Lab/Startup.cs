using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5_Lab.Startup))]
namespace Week5_Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
