using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenHungCuong2011060110.Startup))]
namespace NguyenHungCuong2011060110
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
