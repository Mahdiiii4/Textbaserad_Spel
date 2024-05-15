namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende
    {
        private int hp = 100; //Bestäma hp för fiende.
        private int stamina = 120;
        int turn = 2;
        public override int Attack(int target) //metod för attackera. Den måste ta in target som den ska gör skada till.
        {
            target = target - 5; //minskar hp med 5.
            Console.WriteLine($"Du fick 5 skada av en stark fiende"); //Text så att spelar vet vad händer.
            Console.WriteLine("");
            return target; //Return spelare hp.
        }
    }
}