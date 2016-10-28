using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsyncLogInSignUp.Startup))]
namespace AsyncLogInSignUp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
