using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineExaminationSystem1.Startup))]
namespace OnlineExaminationSystem1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
