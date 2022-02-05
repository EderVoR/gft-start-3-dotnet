using System;
using Construtores.Models;

public class Program
{
    public static void Main(String[] args)
    {
        Data data = new Data();
        data.SetMes(20);

        data.ApresentarMes();
        // Tratamento de Construtor privado
        // Log log = Log.GetInstance();
        // log.PropriedadeLog = "teste de isntancia";
        // Log log2 = Log.GetInstance();
        // Console.WriteLine($"{log2.PropriedadeLog}");

        // Aluno p1 = new Aluno("Eder", "Vieira", "Teste");
        // p1.Apresentar();
    }
}