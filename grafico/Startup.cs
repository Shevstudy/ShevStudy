using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(grafico.Startup))]
namespace grafico
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
