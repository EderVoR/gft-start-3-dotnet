using System;

public class Program
{
    public static void CriarArquivo(string path)
    {
        try
        {
            //Cria o arquivo
            using var sw = File.CreateText(path);
            //Insere uma linha no arquivo
            sw.WriteLine("teste de arquivo");
            //Finaliza o arquivo e salva as alteracoes
            sw.Flush();            
        }
        catch
        {            
            Console.WriteLine("O nome do arquivo esta invalido!");
        }
    }

    public static string LimparNome(string nome)
    {
        //Valida os caracteres invalidos e faz a remoção doe mesmos
        foreach (var @char in Path.GetInvalidFileNameChars())
        {
            //Remove os caracteres invalidos por espaco
            nome = nome.Replace(@char, ' ');
        }
        return nome;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("Informe o nome do arquivo: ");
        var nomeArquivo = Console.ReadLine();

        nomeArquivo = LimparNome(nomeArquivo);

        var path = Path.Combine(Environment.CurrentDirectory, $"{nomeArquivo}.txt");
        
        CriarArquivo(path);

        Console.WriteLine("Aperte enter para finalizar...");
        Console.ReadLine();
    }
}

