using System;
using ExemploPOO.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Pessoa p1 = new Pessoa();

        p1.Nome = "Eder";
        p1.Idade = 34;

        p1.Apresentar();
    }
}