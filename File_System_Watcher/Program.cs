using System;

public class Program
{
    public static void Main(String[] args)
    {
        var path = @"C:\workspace\gft-start-3-dotnet\directory_and_directoryinfo\globo";
        var fsw = new FileSystemWatcher(path);
        fsw.Created += OnCreated;
        fsw.Renamed += OnRenamed;
        fsw.Deleted += OnDeleted;

        fsw.EnableRaisingEvents = true;
        fsw.IncludeSubdirectories = true;
        Console.WriteLine("Precione [enter] para finalizar....");
        Console.ReadLine();
    }

    private static void OnDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"O arquivo {e.Name} foi deletado.");
    }

    private static void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
    }

    private static void OnCreated(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine($"O arquivo {e.Name} foi criado.");
    }
}