using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_to_book_cleaning_services.Startup))]
namespace Website_to_book_cleaning_services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
