using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSG.IKAM.WEB.Startup))]
namespace DSG.IKAM.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
