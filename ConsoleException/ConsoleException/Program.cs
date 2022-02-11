 namespace ConsoleException
{
    public class Program
    {
        public static void Main(String [] args)
        {
            int a = 100, b = 0;
            double resultado;

            try
            {
                resultado = Dividir(a, b);
                Console.WriteLine($"{a} divido por {b} é {resultado}");                
            }
            //Clausula when é verificada para validar entrar no catch
            catch (DivideByZeroException exp) when (a < 0)
            {
                Console.WriteLine(exp.Message + " Zero Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Operação finalizada.");
            }

            
            double Dividir(int x, int y)
            {
                if(y <= 0)
                    throw new MyClassException("Minha mensagem customizada de erro!");
                
                return x / y;
            }
        }

    }    
}