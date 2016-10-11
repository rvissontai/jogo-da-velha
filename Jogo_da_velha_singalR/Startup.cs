using Microsoft.Owin;
using Owin;
using SignalR;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(Jogo_da_velha_singalR.Startup))]
namespace Jogo_da_velha_singalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            //Resetar as partidas no inicio da aplicação
            JogoHub.Partidas = new System.Collections.Generic.List<Models.PartidaViewModel>();

            var task = Task.Run(() => app.MapSignalR());
            task.Wait(300);

            //try again if it fails just to be sure ;)
            if (task.IsCanceled) Task.Run(() => app.MapSignalR()).Wait(300);
        }
    }
}
