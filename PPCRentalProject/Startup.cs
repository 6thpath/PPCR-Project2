using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PPCRentalProject.Startup))]
namespace PPCRentalProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
