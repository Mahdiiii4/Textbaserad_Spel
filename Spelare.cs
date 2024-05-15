namespace Textbaserad_Spel
{
    public class Spelare
    {
        private int hp = 100; //bestäma spelare hp.

        public int HP //property för att kunna ändra och läsa hp.
        {
            get{return hp;}
            set{hp = value;}
        }

        public int Attackera(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            target = target - 10; //minskar hp med 10.
            return target; //Return spelare hp.
        }

        public void SkrivaUt() //Metod för att skriva ut din hp.
        {
            Console.WriteLine($"Din hp: {hp}"); //Text för spelare.
        }
    }
}