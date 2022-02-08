using System;
using ExemplosColecoes.Helper;

public class Program
{
    public static void Main(String[] args)
    {
        int[] arrayInteiros = new int[5] {6, 3, 8, 1, 9};

        OperacoesArray op = new OperacoesArray();

        op.OrdenarBubbleSort(ref arrayInteiros);
        op.ImprimirArray(arrayInteiros);
    }
}