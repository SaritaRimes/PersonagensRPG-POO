namespace Desafio_AbstraindoRPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, int HP, int maximumHP, int MP, int maximumMP) : base("", 0, 0, 0, 0, 0)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.maximumHP = maximumHP;
            this.maximumMP = maximumMP;
            this.MP = MP;
            this.HeroType = "Ninja";
        } 
    }
}