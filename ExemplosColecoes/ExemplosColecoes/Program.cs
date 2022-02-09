using System;
using System.Collections.Generic;
using ExemplosColecoes.Helper;

public class Program
{
    public static void Main(String[] args)
    {
        OperacoesLista opLista = new OperacoesLista();
        List<string> estados = new List<string>{"SP", "MS", "RS"};
        string[] estadosArray = new string[2] {"SC", "PR"};
        // estados.Add("SP");
        // estados.Add("MS");
        // estados.Add("RS");

        //estados.AddRange(estadosArray);

        estados.Insert(1, "RJ");

        Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");
        
        //estados.Remove("SP");
        opLista.ImprimirLista(estados);

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