using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETicaret.Web.Startup))]
namespace ETicaret.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
