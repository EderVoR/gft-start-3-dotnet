using System;

public class Program
{
    public static void Main(String[] args)    
    {
        CriarCsv();
        var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "usuario-exportado.csv");
        if(File.Exists(path))
        {

            using var sr = new StreamReader(path);
            //Fara a leitura da linha e cada separacao por virgula sera colocado no array
            //Quando a leitura for nula ele ira ignorar o Split por causa do comando dado pelo 
            //ponto de interrogação (?)
            var cabecalho = sr.ReadLine()?.Split(",");

            while(true)
            {
                var registro = sr.ReadLine()?.Split(",");
                if(registro == null) break;
                for (int i = 0; i < registro.Length; i++)
                {
                    Console.WriteLine($"{cabecalho?[i]}: {registro[i]}");
                }
                Console.WriteLine("----------------------");
            }
        }
        else
        {
            Console.WriteLine($"O {path} não foi localizado.");
        }
            Console.WriteLine("\n\nPrecione [enter] para finalizar.....");
            Console.ReadLine();

        static void CriarCsv()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Saida");    
            var pessoas = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "Jose da Silva",
                    Email = "js@gmail.com",
                    Telefone = 12345678,
                    Nascimento = new DateOnly(year: 1988, month: 1, day: 30)
                },
                new Pessoa()
                {
                    Nome = "Deivison Ribeiro",
                    Email = "dr@hotmail.com",
                    Telefone = 789456123,
                    Nascimento = new DateOnly(year: 1989, month: 1, day: 20)
                }
            };
            
            var di = new DirectoryInfo(path);
            if(!di.Exists)
            {
                di.Create();
                path = Path.Combine(path, "usuario.csv");
            }

            using var sw = new StreamWriter(path);
            sw.WriteLine("nome,email,telefone,nascimento");
            foreach (var pessoa in pessoas)
            {
                var linha = $"{pessoa.Nome},{pessoa.Email},{pessoa.Telefone},{pessoa.Nascimento}";
                sw.WriteLine(linha);
            }
        }        
    }
}
class Pessoa
{
    public string Nome {get;set;}
    public string Email {get; set;}
    public int Telefone {get;set;}
    public DateOnly Nascimento {get;set;}
}