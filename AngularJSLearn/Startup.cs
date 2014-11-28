using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSLearn.Startup))]
namespace AngularJSLearn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
