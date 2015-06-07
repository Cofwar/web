using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cofwar.com.Startup))]
namespace cofwar.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
