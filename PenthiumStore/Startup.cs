using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PenthiumStore.Startup))]
namespace PenthiumStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
