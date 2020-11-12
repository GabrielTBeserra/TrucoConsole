using System;
using System.Collections.Generic;
using System.Linq;

namespace TrucoConsole.entity
{
    class Time
    {
        private List<Player> players;
        public List<Player> Players { get; }
        private int placar;
        public int Placar { get { return placar; } }

        public Time(){}

        public Time(List<Player> p)
        {
            players = p;
        }

        public Time(params Player[] p)
        {
            players = p.ToList<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (players.Count < 2)
            {
                players.Add(player);
                Console.WriteLine("Player Adicionado");
            }
            else
            {
                Console.WriteLine("Limite de players");
            }

        }

        public void ExiirJogadores()
        {
            foreach(Player p in players)
            {
                Console.WriteLine($"Jogador: {p.Nome}");
            }
        }

        public void AddPonto(int ponto)
        {
            placar += ponto;
        }
    }
}
