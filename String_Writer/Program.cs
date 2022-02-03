using System;

public class Program
{
    public static void Main(String[] args)
    {
        string TextReaderText = "Elas vão te ensinar do absoluto ZERO, ou seja, desde o comecinho,"+
                "conceito a conceito. E vamos evoluindo na prática, mão na massa, até conseguirmos"+
                "criar um site completo e 100% responsivo, ou seja, ele vai ficar visualmente bem tanto"+
                "no computador quanto no celular. Você vai adorar, eu preparei com carinho.\n\n Mas queria"+
                "ter um PAPO SÉRIO contigo agora...\n\n Quero já expor um dos pontos mais importantes da B7Web,"+
                "que é a honestidade e transparência...";

        Console.WriteLine("Texto original: " + TextReaderText);
        string linha, paragrafo = null;
        var sr = new StringReader(TextReaderText);

        while(true)
        {
            linha = sr.ReadLine();
            if(linha != null)
            {   
                paragrafo += linha + " ";
            }
            else
            {
                paragrafo += "\n";
                break;
            }
        }

        Console.WriteLine($"Texto modificado.\n {paragrafo}");
        int caracterLido;
        char caracterConvertido;

        var sw = new StringWriter();
        sr = new StringReader(paragrafo);

        while(true)
        {
            caracterLido = sr.Read();
            if(caracterLido == -1) break;

            caracterConvertido = Convert.ToChar(caracterLido);

            if(caracterConvertido == '.')
            {
                sw.Write("\n\n");
                sr.Read();
                sr.Read();
            }
            else
            {
                sw.Write(caracterConvertido);
            }            
        }
        Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
        Console.ReadLine();
    }
}