using jogo_rpg_c_sahrp.src.Entities;

public class Program
{
    public static void Main(String[] args)
    {
        Hero hero = new Hero("Arus", 23, "Knight");
        Wizard mago = new Wizard("Malefico", 99, "Devil");

        Console.WriteLine(hero.Attack());
        //Console.WriteLine(mago.Attack());
    }
}