namespace ExemplosColecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = String.Join(", ", array);
            Console.WriteLine(linha);
            // for (int i = 0; i < array.Length; i++)
            // {
            //     Console.WriteLine(array[i]);
            // }                    
        }

        public void Ordenar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copia(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)
        {
            return Array.Find(array, element => element == valor);
        }

        public int ObterIndice(int[] array, int valor)
        {
            return Array.IndexOf(array, valor);
        }

        public void Redimencionar(ref int[] array, int valor)
        {
            Array.Resize(ref array, valor);
        }

        public string[] ConverterParaArrayString(int[] array)
        {
            return Array.ConvertAll(array, element => element.ToString());
        }
    }
}