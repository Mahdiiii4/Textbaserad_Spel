namespace Textbaserad_Spel
{
    public class Spelare : Fiende
    {
        private int hp = 100;
        private int stamina = 100;
        private int damage = 10;
        private int exhaustion = 20;
        private int regain = 30;
        private int turn = 2;
        private int points = 0;
        public int Stamina 
        {
            get{return stamina;}
            set{stamina = value;}
        }
        public int Points
        {
            get{return points;}
            set{points = value;}
        }
        public int Turn
        {
            get{return turn;}
            set{turn = value;}
        }
        public void Attack(Fiende target)
        {
            if(stamina < 20)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
            }
            else
            {
                
                target.HP -= damage;
                stamina -= exhaustion;
                turn -= 1;
                points += 10;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target.HP +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }

        public void StarkAttack(Fiende target)
        {
            if(stamina < 40)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
            }
            else if(turn < 2)
            {
                Console.WriteLine("Du har inte tillräckligt turns!");
            }
            else
            {
                target.HP -= 30;
                stamina -= exhaustion - 20;
                turn -= 2;
                points -= 20;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target.HP +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }

        public void Vila()
        {
            turn -= 1;
            stamina += 30;
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