using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jogo_da_velha_singalR.Models
{
    public class JogadorViewModel
    {
        public string Apelido { get; set; }
        public string Id { get; set; }
    }

    public class PartidaViewModel
    {
        public PartidaViewModel()
        {
            Jogadores = new List<JogadorViewModel>();
        }

        public int Codigo { get; set; }
        public List<JogadorViewModel> Jogadores { get; set; }
    }
}