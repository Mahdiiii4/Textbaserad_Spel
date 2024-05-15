namespace Textbaserad_Spel
{
    public class StarkFiende
    {
        private int hp = 100; //Bestäma hp för fiende.

        public int HP //property för att kunna ändra och läsa hp.
        {
            get{return hp;}
            set{hp = value;}
        }

        public int Attackera(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            target = target - 5; //minskar hp med 5.
            Console.WriteLine($"Du fick 5 skada av en stark fiende"); //Text så att spelar vet vad händer.
            return target; //Return spelare hp.
        }
    }
}