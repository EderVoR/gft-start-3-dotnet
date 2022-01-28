public class Program
{
    public void Demo1()
    {
        int a = 2;
        Adicionar20(a);
        Console.WriteLine($"O valor da variavel a é {a}");
    }
    static void Adicionar20(int a)
    {
        a = a + 20;        
    }
    static void TrocarNome(Pessoa p, string NovoNome)
    {
        p.Nome = NovoNome;
    }
    public static void Main()
    {
        Pessoa p = new Pessoa();

        p.Nome = "Eder";
        p.Idade = 33;
        p.Documento = "1487016";

        TrocarNome(p, "Matheus");

        Console.WriteLine($"O novo nome é {p.Nome}");

    }
}