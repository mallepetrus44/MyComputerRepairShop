using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyComputerRepairShop.Startup))]
namespace MyComputerRepairShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
