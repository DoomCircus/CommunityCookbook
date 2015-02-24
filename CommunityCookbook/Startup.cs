using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityCookbook.Startup))]
namespace CommunityCookbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
