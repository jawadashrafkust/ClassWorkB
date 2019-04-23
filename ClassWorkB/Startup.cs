using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassWorkB.Startup))]
namespace ClassWorkB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
