using System;

namespace App_Dotnet
{
    public class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        public static void Main(String[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSerie();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        //AtualizarSerie();
                        break;
                    case "4":
                       // ExcluirSerie();
                        break;
                    case "5":
                       // VisualizarSerie();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario(); 
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.WriteLine();
        }

        private static void ListarSerie()
        {
            Console.WriteLine("Listar Series.");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma serie encontrada");
                return;
            }

            foreach (var serie  in lista)
            {
                Console.WriteLine($"#ID {serie.RetornaId()} - {serie.RetornaTitulo()}");
            }
        }

        public static void InserirSerie()
        {
            Console.WriteLine("Inserir nova serie");
            foreach (var i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo da serie:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Insere(novaSerie);
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series ao seu dispor.");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar series.");
            Console.WriteLine("2 - Inserir uma nova serie.");
            Console.WriteLine("3 - Atualizar serie");
            Console.WriteLine("4 - Excluir uma serie");
            Console.WriteLine("5 - Visualizar serie");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario =  Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}