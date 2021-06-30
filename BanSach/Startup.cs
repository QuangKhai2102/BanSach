using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BanSach.Startup))]
namespace BanSach
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
