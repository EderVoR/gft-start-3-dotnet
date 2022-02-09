namespace ExemplosColecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"Estado na posicao {i} é {lista[i]}");
            }
        }
    }
}