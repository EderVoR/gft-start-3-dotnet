using System;
using System.Text;

public class Program
{
    public static void Main(String[] args)
    {
        var sb = new StringBuilder();
        sb.AppendLine("Caracteres na primeira linha");
        sb.AppendLine("e a segunda");
        sb.AppendLine("e o fim");

        using var sr = new StringReader(sb.ToString()); 
        var buffer = new char[10];
        var tamanho = 10;
        
        do
        {
            tamanho  = sr.Read(buffer);
            Console.Write(string.Join("", buffer));

        }while (tamanho >= buffer.Length);
        
        Console.WriteLine("Precione [enter] para finalizar...");
        Console.ReadLine();
    }
}