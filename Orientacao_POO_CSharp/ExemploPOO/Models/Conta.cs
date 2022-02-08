namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double Saldo {get; set;}

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {Saldo}");
        }    
    }
}