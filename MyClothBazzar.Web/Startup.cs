using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyClothBazzar.Web.Startup))]
namespace MyClothBazzar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
