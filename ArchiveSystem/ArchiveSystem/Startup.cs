using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArchiveSystem.Startup))]
namespace ArchiveSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
