namespace TrucoConsole.entity
{
    class Carta
    {
        private Naipe naipe;

        public Naipe Naipe { get { return naipe; } }

        private int valor;

        private int Valor { get { return valor; } }


        public Carta(Naipe naipe, int valor)
        {
            this.naipe = naipe;
            this.valor = valor;
        }
    }
}
