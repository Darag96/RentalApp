using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RentalApplication.Startup))]
namespace RentalApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
