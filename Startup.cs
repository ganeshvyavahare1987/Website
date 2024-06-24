using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarnivalCinema.Startup))]
namespace CarnivalCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
