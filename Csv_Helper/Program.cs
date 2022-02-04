using System;
using System.Globalization;
using Csv_Helper.Model;

public class Program
{
    public static void Main(String[] args)
    {
        //LerCSVComDynamyc();
        LerCSVComClasse();


        Console.WriteLine("Aperte [enter] para finalizar....");
        Console.ReadLine();
        
        static void LerCSVComClasse()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "novos-usuarios.csv");
            var fi = new FileInfo(path);

            //Verifica a existencia do arquivo, caso contrario emite um alerta
            if(!fi.Exists)
                throw new FileNotFoundException($"O arquivo {path} não foi localizado.");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture);
            using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);

            var registros = csvReader.GetRecords<Usuario>();

            foreach (var registro in registros)        
            {
                Console.WriteLine($"nome: {registro.Nome}");
                Console.WriteLine($"email: {registro.Email}");
                Console.WriteLine($"telefone: {registro.Telefone}");
                Console.WriteLine("--------------");
            }
        }


        static void LerCSVComDynamyc()
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