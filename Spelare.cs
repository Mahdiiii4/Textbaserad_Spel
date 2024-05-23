namespace Textbaserad_Spel
{
    public class Spelare
    {
        private int hp = 100;
        Random staminaGain = new Random();
        private int stamina = 100;
        private int staminaRegain;
        Random damageCrit = new Random();
        private int damage;
        private int exhaustion = 20;
        Random hpGain = new Random();
        private int hpRegain;
        private int turn = 2;
        private int points = 0;
        Random chest = new Random();
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
            damage = damageCrit.Next(1, 11);
            if(stamina < 20)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                Console.WriteLine("");
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
            damage = damageCrit.Next(5, 16);
            if(stamina < 40)
            {
                Console.WriteLine("Du har inte tillräckligt stamina!");
                Console.WriteLine("");
            }
            else if(turn < 2)
            {
                Console.WriteLine("Du har inte tillräckligt turns!");
                Console.WriteLine("");
            }
            else
            {
                target.HP -= damage;
                stamina -= exhaustion + 30;
                turn -= 2;
                points += 20;
                Console.WriteLine("Du använde en stark attack mot en fiende. Fiende hp: "+ target.HP +".");
                Console.WriteLine("Stamina -" + exhaustion + ".");
                Console.WriteLine("");
            }
        }
        public void Vila()
        {
            staminaRegain = staminaGain.Next(15, 31);
            stamina += staminaRegain;
            turn -= 1;
            points += 10;
            Console.WriteLine("Du vilar lite.");
            Console.WriteLine("Stamina +" + staminaRegain + ".");
            Console.WriteLine("");
        }
        public void HealUp()
        {
            hpRegain = hpGain.Next(10, 16);
            hp += hpRegain;
            turn -= 1;
            points += 10;
            Console.WriteLine("Du äter en äpple");
            Console.WriteLine("HP +" + hpRegain + ".");
            Console.WriteLine("");
        }
        public void Chest()
        {
            int chestChance = chest.Next(1, 3);
            Console.WriteLine("Du hitade en låda och det står graits 200 points bredvid den.");
            Console.WriteLine("*Hög risk*");
            Console.WriteLine("Vill du öppna den? Y/N");
            string chestSvar = Console.ReadLine();
            if(chestSvar.ToLower() == "y" && chestChance == 1)
            {
                hp -= 50;
                Console.WriteLine("Det fanns en bomb i lådan!");
                Console.WriteLine("Hp -50");
            }
            else if(chestSvar.ToLower() == "y" && chestChance == 2)
            {
                points += 200;
                Console.WriteLine("Du fick 200 points!");
            }
            else if (chestSvar.ToLower() == "n")
            {
                Console.WriteLine("");
            }
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
        public void Förtsätta()
        {
            hp += hpRegain;
            Console.WriteLine("Du vann!");
            Console.WriteLine("HP +" + hpRegain + ".");
            Console.WriteLine("Vill du förtsätta? Y/N");
            string förtsätta = Console.ReadLine();
            Console.WriteLine("");

            if(förtsätta.ToLower() == "y")
            {
                Console.WriteLine("Round 2");
                Console.WriteLine("");
                Turn = 2;
            }
            else
            {
                Spara();
            }
        }
        public void Förlora()
        {
            Spara();
            Console.WriteLine("Du förlorade");
        }
    }
}