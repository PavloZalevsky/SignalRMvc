using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalRMvc.Startup))]
namespace SignalRMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
