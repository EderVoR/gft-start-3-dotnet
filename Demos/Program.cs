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

    static void Demo3()
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

    static void Demo4()
    {
        string Nome = "Eder";

        TrocarNome(Nome, "Jose");

        Console.WriteLine($"O novo nome é: {Nome}");
    }

    static void Demo5()
    {
        int[] par = new int []{0,2,4,6,8};

        MudarParaImpar(par);

        for (int i = 0; i < par.Length; i++)
        {
            Console.WriteLine($"Numeros impares: {string.Join(",", par)}");
        }
    }
    static void Demo6()
    {
        int[] numeros = new int[]{0,2,4,6,8};
        Console.WriteLine("Digite o número que gostaria de encontrar:");
        var numero = int.Parse(Console.ReadLine());

        var idxEncontrado = EncontrarNumero(numeros, numero);

        if(idxEncontrado > 0)
            Console.WriteLine($"O numero encontrado  foi: {idxEncontrado}");
        else    
            Console.WriteLine("Número não encontrado");
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

    static void TrocarNome(string nome, string novoNome)
    {
        nome = novoNome;
    }
    static void MudarParaImpar(int[] pares)
    {
        for(int i = 0; i < pares.Length; i ++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumero(int[] numeros, int num)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] == num)
                return i;
        }
        return -1;
    }
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {   
            //Necessario informar o campo que deseja verificar no IF
            if(item.Nome == pessoa.Nome)
                return true;
        }
        return false;
    }
    public static void Main()
    {
        List<Pessoa> pessoas = new List<Pessoa>()
        {
            new Pessoa(){Nome = "Ricardo"},
            new Pessoa(){Nome = "José"},
            new Pessoa(){Nome = "Maria"},
            new Pessoa(){Nome = "Fabiana"},
            new Pessoa(){Nome = "Eduardo"}
        };

        Console.WriteLine($"Digite a pessoa que gostaria de localizar: ");
        var nome = Console.ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if(encontrado == true)
            Console.WriteLine("Pessoa encontrada");
        else
            Console.WriteLine("Pessoa não encontrada");
    }
}