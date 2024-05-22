namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende
    {
        bool showUp = true;
        public StarkFiende(int hp, int rage, int damage, int exhaustion) : base(hp, rage, damage, exhaustion)
        {
        }
        int turn = 2;
        public override void Attack(Spelare spelare)
        {
            if(rage < 30)
            {
                rage += 30;
                Console.WriteLine("Fiende vilar lite");
                Thread.Sleep(1000);
                Console.WriteLine("Rage +" + rage + ".");
            }
            else
            {
                spelare.HP -= damage;
                rage = rage - exhaustion;
                Console.WriteLine("Du fick " + damage + " skada.");
                Thread.Sleep(1000);
                Console.WriteLine("fiende rage -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }
        public override void ShowUpText()
        {
            if(showUp)
            {
                Console.WriteLine("En stark fiende dyker up!");
                Thread.Sleep(1000);
                Console.WriteLine(" ");
                showUp = false;
            }
        }
    }
}