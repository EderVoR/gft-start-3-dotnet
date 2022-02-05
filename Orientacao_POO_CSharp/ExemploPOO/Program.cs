using System;
using ExemploPOO.Models;

public class Program
{
    public static void Main(String[] args)
    {
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);
            Console.WriteLine($"Área: {r.ObterArea()}");

            Retangulo r2 = new Retangulo();
            r2.DefinirMedidas(-30, 30);
            Console.WriteLine($"Área: {r2.ObterArea()}");

        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Eder";
        // p1.Idade = 34;
        // p1.Apresentar();
    }
}