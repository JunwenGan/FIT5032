using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLecture2Demo.Startup))]
namespace MyLecture2Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
