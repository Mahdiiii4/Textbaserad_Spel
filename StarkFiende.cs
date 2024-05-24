namespace Textbaserad_Spel
{
    public class StarkFiende : Fiende //arvar av fiende.
    {
        Random damageCrit = new Random(); //random för damage.
        bool showUp = true; //Bool så att medelande om spelare möter fiende ska körs en gång.
        public StarkFiende(int hp, int rage, int exhaustion) : base(hp, rage, exhaustion) //Konstruktor som sätter värde på egenskapper.
        {
        }
        public override void Attack(Spelare spelare) //Funktion för fiende att attackera spelare. En virtual metod som tar in spelare objekt.
        {
            damage = damageCrit.Next(15, 26); //Sätter värde av random damage på veriable damage. Skada som spelare tar är mellan 10 och 20.
            if(rage < 30) //Om fiende har mindre rage än 10.
            {
                rage += 30; //ger rage till fiende.
                Console.WriteLine("Stark fiende vilar lite"); //Information för spelare.
                Console.WriteLine("Rage +" + rage + "."); //Information för spelare.
            }
            else
            {
                spelare.HP -= damage; //Om fiende har tillräckligt rage så attackera de spelare hp och minska den med damage som är slumpmassigt.
                rage -= exhaustion; //Attacks tar rage och rage minskar med exhaustion.
                Console.WriteLine("Du fick " + damage + " skada."); //Information för spelare.
                Console.WriteLine("Stark fiende rage -" + exhaustion + "."); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
        }
        public override void ShowUpText()
        {
            if(showUp) //Så att medelande visar en gång.
            {
                Console.WriteLine("En stark fiende dyker upp!"); //Information för spelare.
                Console.WriteLine(" "); //Information för spelare.
                showUp = false; //Så att medelande visar en gång.
            }
        }
    }
}