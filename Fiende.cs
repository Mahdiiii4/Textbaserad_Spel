namespace Textbaserad_Spel
{
    public class Fiende
    {
        private int hp = 50; //Bestäma hp för fiende.
        private int stamina = 60;
        public int HP //property för att kunna ändra och läsa hp.
        {
            get{return hp;}
            set{hp = value;}
        }
        public virtual int Attack(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            target = target - 15; //minskar hp med 15.
            stamina = stamina - 20;
            Console.WriteLine($"Du fick 10 skada av fiende"); //Text så att spelar vet vad händer.
            Console.WriteLine("");
            return target; //Return spelare hp.
        }
    }
}