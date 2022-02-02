using System;

public class Program
{
    public static void CopiarAquivo(string pathOrigem, string pathDestino)
    {
        if(!File.Exists(pathOrigem))
        {
            Console.WriteLine("O arquivo não exite na pasta de origem");
            return;
        }
        if(File.Exists(pathDestino)){
            Console.WriteLine("O arquivo ja exite na pasta de destino");
            return;
        }
        File.Copy(pathOrigem, pathDestino);
    }
    public static void MoverArquivo(string pathOrigem, string pathDestino) 
    {
        if(!File.Exists(pathOrigem))
        {
            Console.WriteLine("O arquivo não existe na pasta de origem.");
            return;
        }    
        if(File.Exists(pathDestino))
        {
            Console.WriteLine("O arquivo ja existe na pasta destino.");
            return;
        }
        File.Move(pathOrigem, pathDestino);
    }
    //Cria um arquivo com as informações da região a ser salva
    public static void CriarArquivo()
    {
        var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
        //Verifica se ja existe o arquivo antes de criar
        if(!File.Exists(path))
        {
            using var sw = File.CreateText(path);
            sw.WriteLine("População: 213MM");
            sw.WriteLine("IDH: 0,910");
            sw.WriteLine("Dados atualizado em 24/01/2020");
        }
    }
    public static void CriarDiretoriosGlobo()
    {
        //Cria o diretorio Globo
        var path = Path.Combine(Environment.CurrentDirectory, "globo");
        //Verifica se ja existe os diretorios para criar ou não
        if(!Directory.Exists(path))
        {
            //Armazena os dados do diretorio Globo
            var dirGlobo = Directory.CreateDirectory(path);
            //Cria os subdiretorios baseado nas informacoes do diretorio pai Globo
            var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
            var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
            var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");
            //Cria os subdiretorios baseados nos pais
            dirAmNorte.CreateSubdirectory("USA");
            dirAmNorte.CreateSubdirectory("Canada");
            dirAmNorte.CreateSubdirectory("Mexico");
            dirAmCentral.CreateSubdirectory("Panama");
            dirAmCentral.CreateSubdirectory("Costa Rica");
            dirAmSul.CreateSubdirectory("Brasil");
            dirAmSul.CreateSubdirectory("Argentina");
            dirAmSul.CreateSubdirectory("Paraguay");
        }
    }
    public static void Main(String[] args)
    {
        CriarDiretoriosGlobo();
        CriarArquivo();

        var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
        var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");
        
        MoverArquivo(origem, destino);
    }
}