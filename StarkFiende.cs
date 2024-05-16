namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende
    {
        private int hp = 100;
        private int rage = 120;
        private int damage = 10;
        private int exhaustion = 30;
        int turn = 2;
        public override int Attack(int target)
        {
            if(rage < 30)
            {
                rage = rage + 30;
                Console.WriteLine("Fiende vilar lite");
                Console.WriteLine("Rage +" + rage + ".");
            }
            else
            {
                target = target - damage;
                rage = rage - exhaustion;
                Console.WriteLine("Du fick " + damage + " skada.");
                Console.WriteLine("fiende rage -" + exhaustion + ".");
                Console.WriteLine("");
            }
            return target;
        }
    }
}