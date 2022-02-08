using System;
using ExemplosColecoes.Helper;

public class Program
{
    public static void Main(String[] args)
    {
        int[] arrayInteiros = new int[5] {6, 3, 8, 1, 9};
        int[] arrayCopia = new int[10];

        OperacoesArray op = new OperacoesArray();

        var todosMaiorQue = op.TodosMaiorQue(arrayInteiros, 0);

        //op.OrdenarBubbleSort(ref arrayInteiros);
        // op.Ordenar(ref arrayInteiros);
        // op.ImprimirArray(arrayInteiros);
    }
}