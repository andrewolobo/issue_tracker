using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(issue_tracker_one.Startup))]
namespace issue_tracker_one
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
