using System;
using ExemploPOO.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine($"Resultado da primeira soma: {calc.Somar(1,2)}");
        Console.WriteLine($"Resultado da segunda soma: {calc.Somar(1,2,3)}");

        // Aluno a1 = new Aluno();
        // a1.Nome = "Eder";
        // a1.Idade = 34;
        // a1.Documento = "123456";
        // a1.Nota = 7;
        // a1.Apresentar();

        // Retangulo r = new Retangulo();
        // r.DefinirMedidas(30, 30);
        // Console.WriteLine($"Área: {r.ObterArea()}");
        // Retangulo r2 = new Retangulo();
        // r2.DefinirMedidas(-30, 30);
        // Console.WriteLine($"Área: {r2.ObterArea()}");

        // Pessoa p1 = new Pessoa();
        // p1.Nome = "Eder";
        // p1.Idade = 34;
        // p1.Apresentar();
    }
}