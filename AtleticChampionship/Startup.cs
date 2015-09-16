using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtleticChampionship.Startup))]
namespace AtleticChampionship
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
