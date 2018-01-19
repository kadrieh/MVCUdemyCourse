using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCUdemyCourse.Startup))]
namespace MVCUdemyCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
