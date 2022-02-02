using System;

public class Program
{
    public static void LerDiretorios(string path)
    {
        if(Directory.Exists(path))
        {
            //Verifica se o diretorio existe antes de listar            
            var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (var dir in diretorios)
            {
                //Pega as informações do diretorio e lista as infornações
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"[Nome]: {dirInfo.Name}");
                Console.WriteLine($"[Raiz]: {dirInfo.Root}");
                if(dirInfo.Parent != null)
                    Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

                Console.WriteLine("\n-----------------------------\n");
            }
        }
        else
            Console.WriteLine($"{path} não existe.");
    }
    public static void LerArquivos(string path)
    {
        //Verifica as pastas e subpastas para verificar os arquivos
        var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        //Verfica todos os arquivos nas pastas e imprime as informações
        foreach (var arq in arquivos)
        {
            var fileInfo = new FileInfo(arq);
            Console.WriteLine($"[Nome]: {fileInfo.Name}");
            Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
            Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTimeUtc}");
            Console.WriteLine($"[Diretorio]: {fileInfo.DirectoryName}");
            Console.WriteLine($"\n----------------------\n");
        }
    }
    public static void Main(String[] args)
    {
        //Recebe o diretorio que quer listar as pastas e faz a chama da função de listar
        var path = @"C:\workspace\gft-start-3-dotnet\directory_and_directoryinfo\globo\";
        //LerDiretorios(path);
        LerArquivos(path);
        Console.WriteLine("\nAperte enter para finalizar....");
        Console.ReadLine();
    }
}