using System;
using System.Collections.Generic;
using TrucoConsole.entity;

namespace TrucoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carta> ListaDeCartas = new List<Carta>();

            foreach (int i in Enum.GetValues(typeof(Naipe)))
            {
                for (int j = 0; j < Marcacao.GetMarcacao().Length; j++)
                {
                    ListaDeCartas.Add(new Carta((Naipe)i, j));
                }
            }
        }
    }
}
