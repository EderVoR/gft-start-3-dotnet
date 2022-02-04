using System;
using System.Globalization;
using Csv_Helper.Model;
//using Csv_Helper.Mapping;


public class Program
{
    
    public static void Main(String[] args)
    {
        //LerCSVComDynamyc();
        //LerCSVComClasse();
        //LerCSVComOutroDelimitador();
        EscreverCsv();

        Console.WriteLine("Aperte [enter] para finalizar....");
        Console.ReadLine();
        
        static void EscreverCsv()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Saida");
            var di = new DirectoryInfo(path);

            if(!di.Exists)
            {
                di.Create();
            }
            path = Path.Combine(path, "usuario-saida.csv");

            var pessoa = new List<Pessoa>()
            {
                new Pessoa()
                {
                    Nome = "Teste",
                    Email = "teste@gmail.com",
                    Telefone = 12345789,
                }
            };

            using var sr = new StreamWriter(path);
            var csvConfig =  new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = "|"
            };            
            using  var csvWriter = new CsvHelper.CsvWriter(sr, csvConfig);
            csvWriter.WriteRecords(pessoa);
        }

        static void LerCSVComOutroDelimitador()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Entrada", "livros.csv");
            var fi = new FileInfo(path);

            //Verifica a existencia do arquivo, caso contrario emite um alerta
            if(!fi.Exists)
                throw new FileNotFoundException($"O arquivo {path} não foi localizado.");

            using var sr = new StreamReader(fi.FullName);
            var csvConfig = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
            using var csvReader = new CsvHelper.CsvReader(sr, csvConfig);
//            csvReader.Context.RegisterClassMap<LivroMap>();
            var registros = csvReader.GetRecords<Livro>();

            foreach (var registro in registros)        
            {
                Console.WriteLine($"titulo: {registro.Titulo}");
                Console.WriteLine($"preço: {registro.Preco}");
                Console.WriteLine($"autor: {registro.Autor}");                
                Console.WriteLine($"lançamento: {registro.Lancamento}");
                Console.WriteLine("--------------");
            }
        }


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