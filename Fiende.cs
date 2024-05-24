namespace Textbaserad_Spel
{
    public class Fiende
    {
        protected int hp; //Egenskaper
        protected int rage; //Egenskaper
        Random damageCrit = new Random(); //Varienande damage.
        protected int damage; //Egenskaper
        protected int exhaustion; //Egenskaper
        bool showUp = true; //Bool så att medelande om spelare möter fiende ska körs en gång.
        public Fiende(int hp, int rage, int exhaustion) //Konstruktor som sätter värde på egenskapper.
        {
            this.hp = hp; //Sätter värde på hp.
            this.rage = rage; //Sätter värde på rage.
            this.exhaustion = exhaustion; //Sätter värde på exhaustion.
        }
        public int HP //Property.
        {
            get{return hp;} //Skickar tillbaka hp.
            set{hp = value;} //Sätter värde på hp.
        }
        public int Rage //Property.
        {
            get{return rage;} //Skickar tillbaka rage.
            set{rage = value;} //Sätter värde på rage.
        }
        public int Damage //Property.
        {
            get{return damage;} //Skickar tillbaka damage.
            set{damage = value;} //Sätter värde på damage.
        }
        public int Exhaustion //Property.
        {
            get{return exhaustion;} //Skickar tillbaka exhaustion.
            set{exhaustion = value;} //Sätter värde på exhaustion.
        }
        public virtual void Attack(Spelare spelare) //Funktion för fiende att attackera spelare. En virtual metod som tar in spelare objekt.
        {
            damage = damageCrit.Next(10, 21); //Sätter värde av random damage på veriable damage. Skada som spelare tar är mellan 10 och 20.
            if(rage < 10) //Om fiende har mindre rage än 10.
            {
                rage += 10; //ger rage till fiende.
                Console.WriteLine("Fiende vilar lite"); //Information för spelare.
                Console.WriteLine("Rage +" + rage + "."); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
            else
            { 
                spelare.HP -= damage; //Om fiende har tillräckligt rage så attackera de spelare hp och minska den med damage som är slumpmassigt.
                rage -= exhaustion; //Attacks tar rage och rage minskar med exhaustion.
                Console.WriteLine("Du fick " + damage + " skada.");  //Information för spelare.
                Console.WriteLine("fiende rage -" + exhaustion + "."); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
        }
        public virtual void ShowUpText() //Funktion för att visa vilken fiende vissas upp för spelaren.
        {
            if(showUp) //Så att medelande visar en gång.
            {
                Console.WriteLine("En fiende dyker upp!"); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
                showUp = false; //Så att medelande visar en gång.
            }
        }
    }
}