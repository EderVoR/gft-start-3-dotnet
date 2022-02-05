using System;
using Construtores.Models;

public class Program
{
    public delegate void Operacao(int x, int y);
    public static void Main(String[] args)
    {
        Matematica m = new Matematica(10, 20);
        m.Somar();
        
        //Delegate e suas funções
        //Operacao op = Calculadora.Somar; <- Outra forma de chamar o delegate
        //Operacao op = new Operacao(Calculadora.Somar);
        //op += Calculadora.Subtrair; //<- Mult Cast para que o delegate execute mais de um metodo
        //op(10, 10); <- Uma Forma de chamar o delegate
        //op.Invoke(10, 10);


        // Get e Set
        // Data data = new Data();
        // data.SetMes(20);
        // data.ApresentarMes();

        // Tratamento de Construtor privado
        // Log log = Log.GetInstance();
        // log.PropriedadeLog = "teste de isntancia";
        // Log log2 = Log.GetInstance();
        // Console.WriteLine($"{log2.PropriedadeLog}");

        // Aluno p1 = new Aluno("Eder", "Vieira", "Teste");
        // p1.Apresentar();
    }
}