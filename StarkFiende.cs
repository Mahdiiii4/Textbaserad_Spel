namespace Textbaserad_Spel
{
    public class StarkFiende
    {
        private int hp = 100;
        private int rage = 120;
        private int damage = 10;
        private int exhaustion = 30;
        int turn = 2;
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
        public void Attack(Spelare spelare)
        {
            if(rage < 30)
            {
                rage += 30;
                Console.WriteLine("Fiende vilar lite");
                Console.WriteLine("Rage +" + rage + ".");
            }
            else
            {
                spelare.HP -= damage;
                rage = rage - exhaustion;
                Console.WriteLine("Du fick " + damage + " skada.");
                Console.WriteLine("fiende rage -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }
    }
}