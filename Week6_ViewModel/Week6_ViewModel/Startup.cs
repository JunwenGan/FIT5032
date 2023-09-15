using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6_ViewModel.Startup))]
namespace Week6_ViewModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
