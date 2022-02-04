using System;
using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {
        LerArquivo();
        Console.WriteLine("Aperte [enter] para finalizar....");
        Console.ReadLine();
        
        
        static void LerArquivo()
        {

                var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "Produtos.csv");

                var fi = new FileInfo(path);

                //Verifica a existencia do arquivo, caso contrario emite um alerta
                if(!fi.Exists)
                    throw new FileNotFoundException($"O arquivo {path} não foi localizado.");

                using var sr = new StreamReader(fi.FullName);
                var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
                using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);

                var registros = csvReader.GetRecords<dynamic>();

                foreach (var registro in registros)        
                {
                    Console.WriteLine($"nome: {registro.Produto}");
                    Console.WriteLine($"marca: {registro.Marca}");
                    Console.WriteLine($"preço: {registro.Preco}");
                    Console.WriteLine("--------------");
                }
            }
    }
}