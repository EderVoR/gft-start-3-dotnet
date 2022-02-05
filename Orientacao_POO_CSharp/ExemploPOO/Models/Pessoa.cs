namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}

        public string Documento {get; set;}

        //virtual permite que o metodo seja sobrescrico quando passado em herança
        public virtual void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}