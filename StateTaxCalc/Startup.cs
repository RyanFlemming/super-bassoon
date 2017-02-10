using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StateTaxCalc.Startup))]
namespace StateTaxCalc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
