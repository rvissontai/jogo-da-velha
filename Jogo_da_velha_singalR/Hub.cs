using Jogo_da_velha_singalR.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SignalR
{
    public class JogoHub : Hub
    {
        public static List<PartidaViewModel> Partidas = new List<PartidaViewModel>();

        public override Task OnConnected()
        {
            //Encontrar uma partida que esteja com menos de 2 jogadores (Aguardando adversário)
            var partidaAguardandoJogador = Partidas.Find(o => o.Jogadores.Count < 2);

            //Todas as partidas estão em andamento, iniciar nova partida
            if(partidaAguardandoJogador == null)
            {
                partidaAguardandoJogador = new PartidaViewModel();
            }
            
            //Adicionar o jogador na partida
            partidaAguardandoJogador.Jogadores.Add(new JogadorViewModel()
            {
                Apelido = string.IsNullOrWhiteSpace(Context.QueryString["Apelido"])  ? Context.QueryString["Apelido"] : "Player_" + (Partidas.Count + 1),
                Id = Context.ConnectionId
            });

            Partidas.Add(partidaAguardandoJogador);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            for(int i=0; i< Partidas.Count; i++)
            {
                var jogador = Partidas[i].Jogadores.Find(j => j.Id == Context.ConnectionId);

                if(jogador != null)
                {
                    Partidas[i].Jogadores.Remove(jogador);
                }
            }

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}