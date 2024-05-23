namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende
    {
        Random damageCrit = new Random();
        bool showUp = true;
        public StarkFiende(int hp, int rage, int damage, int exhaustion) : base(hp, rage, damage, exhaustion)
        {
        }
        public override void Attack(Spelare spelare)
        {
            damage = damageCrit.Next(10, 26);
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