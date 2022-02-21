namespace Desafio_AbstraindoRPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, int HP, int maximumHP, int MP, int maximumMP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.maximumHP = maximumHP;
            this.maximumMP = maximumMP;
            this.MP = MP;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;
        public int maximumHP;
        public int MP;
        public int maximumMP;

        public override string ToString()
        {
            return "Name:       " + Name 
               + "\nLevel:      " + Level 
               + "\nHero Type:  " + HeroType
               + "\nHP:         " + HP + "/" + maximumHP 
               + "\nMP:         " + MP + "/" + maximumMP;
        }
    }
}