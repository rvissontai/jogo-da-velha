using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jogo_da_velha_singalR.Startup))]
namespace Jogo_da_velha_singalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //var task = Task.Run(() => app.MapSignalR());
            //task.Wait(300);

            //try again if it fails just to be sure ;)
            //if (task.IsCanceled) Task.Run(() => app.MapSignalR()).Wait(300);
        }
    }
}
