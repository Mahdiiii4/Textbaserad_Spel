namespace Textbaserad_Spel
{
    public class Fiende
    {
        protected int hp;
        protected int rage;
        protected int damage;
        protected int exhaustion;
        bool showUp = true;
        public Fiende(int hp, int rage, int damage, int exhaustion)
        {
            this.hp = hp;
            this.rage = rage;
            this.damage = damage;
            this.exhaustion = exhaustion;
        }
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
                Console.WriteLine(""); 
            }
        }
        public virtual void ShowUpText()
        {
            if(showUp)
            {
                Console.WriteLine("En fiende dyker up!");
                Console.WriteLine(" ");
                showUp = false;
            }
        }
    }
}