using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TuneCity.Startup))]
namespace TuneCity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
