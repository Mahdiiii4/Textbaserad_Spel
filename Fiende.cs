namespace Textbaserad_Spel
{
    public class Fiende
    {
        private int hp = 50;
        private int rage = 60;
        private int damage = 25;
        private int exhaustion = 10;
        public int HP
        {
            get{return hp;}
            set{hp = value;}
        }
        public int Rage
        {
            get{return rage;}
            set{rage = value;}
        }
        public int Damage
        {
            get{return damage;}
            set{damage = value;}
        }
        public int Exhaustion
        {
            get{return exhaustion;}
            set{exhaustion = value;}
        }
        public virtual void Attack(Spelare spelare)
        {
            if(rage < 10)
            {
                rage += 10;
                Console.WriteLine("Fiende vilar lite");
                Console.WriteLine("Rage +" + rage + ".");
            }
            else
            { 
                
                spelare.HP -= damage;
                rage -= exhaustion;
                Console.WriteLine("Du fick " + damage + " skada.");
                Console.WriteLine("fiende rage -" + exhaustion + ".");
                Console.WriteLine(spelare.HP);
                Console.WriteLine(""); 
            }
        }
    }
}