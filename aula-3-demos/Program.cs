public class Program
{
    public static void Main(String[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Eder";
        p1.Idade = 34;
        p1.EnderecoPessoa = new Endereco()
        {
            Logradouro = "Rua Afonso Pena",
            Numero = 100,
            Cep = "79091520",
            Cidade = "Campo Grande"
        };
    }
}