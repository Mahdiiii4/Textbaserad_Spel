namespace Textbaserad_Spel
{
    public class Spelare
    {
        private int hp = 100;
        private int stamina = 100;
        private int damage = 10;
        private int exhaustion = 20;
        private int staminaRegain = 30;
        private int hpRegain = 30;
        private int turn = 2;
        private int points = 0;
        private string name = "";
        public int HP
        {
            get{return hp;}
            set{hp = value;}
        }
        public int Damage
        {
            get{return damage;}
            set{damage = value;}
        }
        public int Exhaustion
        {
            get{return exhaustion;}
            set{exhaustion = value;}
        }
        public int Stamina 
        {
            get{return stamina;}
            set{stamina = value;}
        }
        public int Points
        {
            get{return points;}
            set{points = value;}
        }
        public int Turn
        {
            get{return turn;}
            set{turn = value;}
        }
        public void Attack(Fiende target)
        {
            if(stamina < 20)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
            }
            else
            {
                target.HP -= damage;
                stamina -= exhaustion;
                turn -= 1;
                points += 10;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target.HP +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }

        public void StarkAttack(Fiende target)
        {
            if(stamina < 40)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
            }
            else if(turn < 2)
            {
                Console.WriteLine("Du har inte tillräckligt turns!");
            }
            else
            {
                target.HP -= 30;
                stamina -= exhaustion - 20;
                turn -= 2;
                points += 20;
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target.HP +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }

        public void Vila()
        {
            stamina += 30;
            hp += 20;
            Console.WriteLine("Du vilar lite.");
            Console.WriteLine("Stamina +" + staminaRegain + ".");
            Console.WriteLine("HP +" + hpRegain + ".");


            Console.WriteLine("");
        }

        public void SkrivaUt()
        {
            Console.WriteLine("Din hp: " + hp + "."); 
            Console.WriteLine("Din stamina: " + stamina + ".");
            Console.WriteLine("");
        }
        public void Spara()
        {
            StreamWriter sr = new StreamWriter("Textfil.txt", true);
            sr.WriteLine(points);
            sr.Close();
        }

        public int Förtsätta(int i)
        {
            hp += 100;
            Console.WriteLine("Du vann!");
            Console.WriteLine("HP +100");
            Console.WriteLine("Vill du förtsätta? Y/N");
            string förtsätta = Console.ReadLine();
            if(förtsätta == "y")
            {
                Console.WriteLine("Round 2");
                i++;
                Turn = 2;
            }
            else
            {
                Spara();
                i = 0;
            }
            return i;
        }
        public int Förlora(int i)
        {
            Console.WriteLine("Du förlorade");
            Spara();
            i = 0;
            return i;
        }
    }
}