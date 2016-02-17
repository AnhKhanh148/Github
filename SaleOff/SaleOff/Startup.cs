using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaleOff.Startup))]
namespace SaleOff
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
