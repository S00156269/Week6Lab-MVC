using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(S00156269Rad2017MVC1.Startup))]
namespace S00156269Rad2017MVC1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
