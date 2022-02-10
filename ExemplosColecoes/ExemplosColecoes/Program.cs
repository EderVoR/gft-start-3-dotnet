using System;
using System.Collections;
using System.Collections.Generic;
using ExemplosColecoes.Helper;

public class Program
{
    public static void Main(String[] args)
    {
        int[] arrayNumbers = new int[] {100, 1, 4, 19, 8, 15, 19, 4, 100};

        var min = arrayNumbers.Min();
        var max = arrayNumbers.Max();
        var media = arrayNumbers.Average();
        var total = arrayNumbers.Sum();
        var distinto = arrayNumbers.Distinct();

        Console.WriteLine($"\n Min: {min}, Max: {max}, Media: {media}");
        Console.WriteLine($"\n Soma: {total}, distinct: {string.Join(", ", distinto)}\n");

        var numerosParesQuery = 
            from num in arrayNumbers
            where num % 2 == 0
            orderby num
            select num;

        var numerosParesMetodo = arrayNumbers.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

        Console.WriteLine($"Query {string.Join(", ", numerosParesQuery)}");
        Console.WriteLine($"Metodos {string.Join(", ", numerosParesMetodo)}");

        // Dictionary<string, string> estados = new Dictionary<string, string>();
        // estados.Add("SP", "São Paulo");
        // estados.Add("MG", "Minas Gerais");
        // estados.Add("SC", "Santa Catarina");        
        // string valorProcurado = "SP";
        // Console.WriteLine($"{estados[valorProcurado]}");
        // estados.Remove("SP");    
        // foreach (KeyValuePair<string, string> item in estados)
        // {
        //     Console.WriteLine($"Chave {item.Key}, Valor {item.Value}");
        // }

        // Stack<string> pilhaLivros = new Stack<string>();
        // pilhaLivros.Push(".NET");
        // pilhaLivros.Push("Java");
        // pilhaLivros.Push("SQL Server");
        // while(pilhaLivros.Count > 0)
        // {
        //     Console.WriteLine($"Próximo livro a ser lido: {pilhaLivros.Peek()}");
        //     Console.WriteLine($"{pilhaLivros.Pop()}  lido com sucesso.");
        // }

        // Queue<string> fila = new Queue<string>();
        // fila.Enqueue("Eder");
        // fila.Enqueue("Vanessa");
        // fila.Enqueue("Vicenzo");
        // while (fila.Count > 0)
        // {
        //     Console.WriteLine($"Vez de {fila.Peek()}");
        //     Console.WriteLine($"{fila.Dequeue()} atendido")
        // }

        // OperacoesLista opLista = new OperacoesLista();
        // List<string> estados = new List<string>{"SP", "MS", "RS"};
        // string[] estadosArray = new string[2] {"SC", "PR"};
        // estados.Add("SP");
        // estados.Add("MS");
        // estados.Add("RS");
        //estados.AddRange(estadosArray);
        // estados.Insert(1, "RJ");
        // Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");    
        //estados.Remove("SP");
        // opLista.ImprimirLista(estados);
        // foreach (var estado in estados)
        // {
        //     Console.WriteLine(estado);
        // }

        // int[] arrayInteiros = new int[5] {6, 3, 8, 1, 9};
        // int[] arrayCopia = new int[10];
        // OperacoesArray op = new OperacoesArray();
        // var todosMaiorQue = op.TodosMaiorQue(arrayInteiros, 0);
        //op.OrdenarBubbleSort(ref arrayInteiros);
        // op.Ordenar(ref arrayInteiros);
        // op.ImprimirArray(arrayInteiros);
    }
}