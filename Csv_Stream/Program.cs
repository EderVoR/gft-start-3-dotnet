using System;

public class Program
{
    public static void Main(String[] args)
    {
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
    }
}