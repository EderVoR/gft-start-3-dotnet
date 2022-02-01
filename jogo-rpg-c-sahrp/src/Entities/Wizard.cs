namespace jogo_rpg_c_sahrp.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(String Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou magia.";
        }
    }
}