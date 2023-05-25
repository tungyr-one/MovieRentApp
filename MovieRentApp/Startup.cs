using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRentApp.Startup))]
namespace MovieRentApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
