using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KuduTestWebApp.Startup))]
namespace KuduTestWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
