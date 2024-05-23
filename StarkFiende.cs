namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende
    {
        Random damageCrit = new Random();
        bool showUp = true;
        public StarkFiende(int hp, int rage, int exhaustion) : base(hp, rage, exhaustion)
        {
        }
        public override void Attack(Spelare spelare)
        {
            damage = damageCrit.Next(15, 26);
            if(rage < 30)
            {
                rage += 30;
                Console.WriteLine("Stark fiende vilar lite");
                Console.WriteLine("Rage +" + rage + ".");
            }
            else
            {
                spelare.HP -= damage;
                rage = rage - exhaustion;
                Console.WriteLine("Du fick " + damage + " skada.");
                Console.WriteLine("Stark fiende rage -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }
        public override void ShowUpText()
        {
            if(showUp)
            {
                Console.WriteLine("En stark fiende dyker upp!");
                Console.WriteLine(" ");
                showUp = false;
            }
        }
    }
}