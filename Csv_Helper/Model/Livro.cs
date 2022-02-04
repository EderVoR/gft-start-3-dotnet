using System;
using CsvHelper.Configuration.Attributes;

namespace Csv_Helper.Model
{
    public class Livro
    {
        //[Name("titulo")]
        public string Titulo {get;set;}
        //[Name("autor")]
        public string Autor {get;set;}
        // [Name("preço")]
        // [CultureInfo("pt-BR")]
        public decimal Preco {get;set;}
        // [Name("lançamento")]
        // [Format("dd/mm/yyyy")]
        public DateOnly Lancamento {get;set;}
    }
}