namespace Textbaserad_Spel
{
    public class Fiende
    {
        private int hp = 30; //Bestäma hp för fiende.

        public int HP //property för att kunna ändra och läsa hp.
        {
            get{return hp;}
            set{hp = value;}
        }

        public int Attackera(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            target = target - 15; //minskar hp med 15.
            Console.WriteLine($"Du fick 10 skada av fiende"); //Text så att spelar vet vad händer.
            return target; //Return spelare hp.
        }
    }
}