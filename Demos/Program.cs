public class Program
{
    public void Demo1()
    {
        int a = 2;
        Adicionar20(a);
        Console.WriteLine($"O valor da variavel a é {a}");
    }

    public static void Demo2()
    {
        Pessoa p = new Pessoa();

        p.Nome = "Eder";
        p.Idade = 33;
        p.Documento = "1487016";

        Pessoa p2 = p.Clone();

        TrocarNome(p, "Matheus");

        Console.WriteLine($@"
            O nome de p é {p.Nome}
            O nome de p2 é {p2.Nome}
            ");
    }
    static void Adicionar20(int a)
    {
        a = a + 20;        
    }
    static void TrocarNome(Pessoa p, string NovoNome)
    {
        p.Nome = NovoNome;
    }

    static StructPessoa TrocarNome(StructPessoa p, string NovoNome)
    {
        p.Nome = NovoNome;
        return p;
    }
    public static void Main()
    {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "123",
            Nome = "Eder",
            Idade = 33
        };

        var p2 = p1;

        p1 = TrocarNome(p1, "Thiago");

        Console.WriteLine($@"
                            O nome de p1 é: {p1.Nome}
                            O nome de p2 é: {p2.Nome}
                        ");

    }
}