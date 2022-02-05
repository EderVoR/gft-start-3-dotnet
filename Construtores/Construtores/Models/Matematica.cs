namespace Construtores.Models
{
    public class Matematica
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int x, int y)
        {
            this.x = x;
            this.y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(x, y);
        }

        public void EventHandler()
        {
            Console.WriteLine("Método executado.");
        }
    }
}