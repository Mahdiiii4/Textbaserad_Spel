namespace Textbaserad_Spel
{
    public class Spelare : Fiende
    {
        private int hp = 100; //bestäma spelare hp.
        private int stamina = 100;
        int turn = 2;
        public int Stamina //property för att kunna ändra och läsa stamina.
        {
            get{return stamina;}
            set{stamina = value;}
        }
        public override int Attack(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            if(stamina <20)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                return target;
            }
            else
            {
                target = target - 10; //minskar hp med 10.
                stamina = stamina - 20;
                turn = turn - 1;
                Console.WriteLine("Du attackerade fiende. Fiende hp: "+ target +".");
                Console.WriteLine("Stamina -20");
                Console.WriteLine("");
                return target; //Return spelare hp.
            }
        }

        public int StarkAttack(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            if(stamina < 40)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                return target;
            }
            else
            {
                target = target - 30; //minskar hp med 10.
                stamina = stamina - 40;
                turn = turn - 2;
                Console.WriteLine("Du attackerade fiende. Fiende hp: "+ target +".");
                Console.WriteLine("Stamina -40");
                Console.WriteLine("");
                return target; //Return spelare hp.
            }
        }

        public void Vila()
        {
            Console.WriteLine("Du vilar lite");
            Console.WriteLine("Stamina +30");
            Console.WriteLine("");
            turn = turn - 1;
            stamina = stamina +30;
        }

        public void SkrivaUt() //Metod för att skriva ut din hp.
        {
            Console.WriteLine($"Din hp: {hp}"); //Text för spelare.
            Console.WriteLine($"Din stamina: {stamina}"); //Text för spelare.
            Console.WriteLine("");
        }
    }
}