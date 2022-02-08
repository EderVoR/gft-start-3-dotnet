using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

public class Program
{
    public static void Main(String[] args)
    {
        FileHelper helper = new FileHelper();
        var caminho = @"C:\workspace\gft-start-3-dotnet\Orientacao_POO_CSharp\ExemploPOO\TrabalhandoComArquivos";
        var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 3"); 
        var caminhoArquivo = Path.Combine(caminho, "arquivo teste stream.txt");
        var novoCaminhoArquivo = Path.Combine(caminho, "PastaTeste2", "Arquivo-move.txt");
        var novoCaminhoCopia = Path.Combine(caminho, "arquivo_copiado.txt");
        var listaStream = new List<string> {"Linha 1", "Linha 2", "linha 3"};
        var listaStreamContinuacao = new List<string> {"Linha 4", "Linha 5", "linha 6"};
        
        //helper.ListarDiretorios(caminho);
        //helper.ListarArquivosDiretorios(caminho);
        //helper.CriarDiretorio(caminhoPathCombine);
        //helper.ApagarDiretorio(caminhoPathCombine, true);
        //helper.CriarArquivoTexto(caminhoArquivo, "Ola, criado seu arquivo de texto");
        //helper.CriarArquivoTextoStream(caminhoArquivo, listaStream);
        //helper.AdicionarTextoStream(caminhoArquivo, listaStreamContinuacao);
        //helper.LerArquivoStream(caminhoArquivo);
        //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
        //helper.CopiarArquivo(novoCaminhoArquivo, novoCaminhoCopia);
        helper.DeletarArquivo(novoCaminhoCopia);

        // ICalculadora calc = new Calculadora();

        // Corrente c = new Corrente();
        // c.Creditar(100);
        // c.ExibirSaldo();

        // Calculadora calc = new Calculadora();
        // Console.WriteLine($"Resultado da primeira soma: {calc.Somar(1,2)}");
        // Console.WriteLine($"Resultado da segunda soma: {calc.Somar(1,2,3)}");

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