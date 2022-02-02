using System;

public class Program
{
    public static void Main(String[] args)
    {
        //Cria o diretorio Globo
        var path = Path.Combine(Environment.CurrentDirectory, "globo");
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