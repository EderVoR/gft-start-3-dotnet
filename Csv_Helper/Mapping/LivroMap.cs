using CsvHelper.Configuration;
using Csv_Helper.Model;
using System.Globalization;

namespace Csv_Helper.Entrada.Mapping
{
    public class LivroMap : ClassMap<Livro>
    {
        public LivroMap()
        {
            Map(x=> x.Autor).Name("autor");
            Map(x=> x.Preco)
                .Name("preço")
                .TypeConverterOption
                .CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
            Map(x=> x.Titulo).Name("titulo");
            Map(x=> x.Lancamento)
                .Name("lançamento")
                .TypeConverterOption
                .Format(new [] {"dd/mm/yyyy"});
        }
    }
}