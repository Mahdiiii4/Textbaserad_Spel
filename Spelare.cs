namespace Textbaserad_Spel
{
    public class Spelare : Fiende
    {
        private int hp = 100;
        private int stamina = 100;
        private int damage = 10;
        private int exhaustion = 20;
        private int regain = 30;
        int turn = 2;
        public int Stamina 
        {
            get{return stamina;}
            set{stamina = value;}
        }
        public override int Attack(int target)
        {
            if(stamina <20)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                return target;
            }
            else
            {
                
                target = target - damage;
                stamina = stamina - exhaustion;
                turn = turn - 1;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
                return target;
            }
        }

        public int StarkAttack(int target)
        {
            if(stamina < 40)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                return target;
            }
            else
            {
                target = target - 30;
                stamina = stamina - 40;
                turn = turn - 2;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
                return target; 
            }
        }

        public void Vila()
        {
            turn = turn - 1;
            stamina = stamina +30;
            Console.WriteLine("Du vilar lite.");
            Console.WriteLine("Stamina +" + regain + ".");
            Console.WriteLine("");
        }

        public void SkrivaUt()
        {
            Console.WriteLine("Din hp: " + hp + "."); 
            Console.WriteLine("Din stamina: " + stamina + ".");
            Console.WriteLine("");
        }
    }
}