using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS174_Final_Mesinovic.Web.Startup))]
namespace CIS174_Final_Mesinovic.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
