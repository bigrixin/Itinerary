using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Itinerary.Startup))]
namespace Itinerary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
