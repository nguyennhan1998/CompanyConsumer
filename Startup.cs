using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyConsumer.Startup))]
namespace CompanyConsumer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
