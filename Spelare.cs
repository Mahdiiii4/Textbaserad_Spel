namespace Textbaserad_Spel
{
    public class Spelare
    {
        private int hp = 100; //Sätter värden på hp.
        Random staminaGain = new Random(); //Random för stamina funktion.
        private int stamina = 100; //Sätter värden på stamina.
        private int staminaRegain; //veriable för att spara random.
        Random damageCrit = new Random(); //Random för damage funktion.
        private int damage; //veriable för att spara random.
        private int exhaustion = 20; //Sätter värde på exhaustion.
        Random hpGain = new Random(); //Random för hp funktion.
        private int hpRegain; //veriable för att spara random.
        private int turn = 2; //Sätter värde på turn.
        private int points = 0; //Sätter värde på points.
        Random chest = new Random(); //Random för låda funktion.
        public int HP //property
        {
            get{return hp;} //Skickar tillbaka värde på hp.
            set{hp = value;} //Sätter värde på hp.
        }
        public int Damage //property
        {
            get{return damage;} //Skickar tillbaka värde på damage.
            set{damage = value;} //Sätter värde på damage.
        }
        public int Exhaustion //property
        {
            get{return exhaustion;} //Skickar tillbaka värde på exhaustion.
            set{exhaustion = value;} //Sätter värde på exhaustion.
        }
        public int Stamina  //property
        {
            get{return stamina;} //Skickar tillbaka värde på stamina.
            set{stamina = value;} //Sätter värde på stamina.
        }
        public int Points //property
        {
            get{return points;} //Skickar tillbaka värde på points.
            set{points = value;} //Sätter värde på points.
        }
        public int Turn //property
        {
            get{return turn;} //Skickar tillbaka värde på turn.
            set{turn = value;} //Sätter värde på turn.
        }
        public void Attack(Fiende target) //Funktion för att spelare ska attackera fiende. Tar in objekt av fiende.
        {
            damage = damageCrit.Next(1, 11); //random för damage och sätter värde på den för damage.
            if(stamina < 20) //Om spelare har mindre stamina än 20 kan spelare inte attackera.
            {
                Console.WriteLine("Du har inte tillräckligt stamina!"); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
            else
            {
                target.HP -= damage; //Om spelare har stamina så minskar den fiende hp med hjälp av damage.
                stamina -= exhaustion; //Minskar stamina med exhaustion.
                turn -= 1; //minskar en turn.
                points += 10; //spelare får 10 points.
                Console.WriteLine("Du attackerade en fiende. Fiende hp: "+ target.HP +"."); //Information för spelare.
                Console.WriteLine("Stamina -" + exhaustion + "."); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
        }
        public void StarkAttack(Fiende target) //Funktion för att spelare ska attackera fiende. Tar in objekt av fiende.
        {
            damage = damageCrit.Next(5, 16); //random för damage och sätter värde på den för damage mellan 5 och 15.
            if(stamina < 40) //Om spelare har mindre stamina än 20 kan spelare inte attackera.
            {
                Console.WriteLine("Du har inte tillräckligt stamina!"); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
            else if(turn < 2) //Eftersom stark attack använder 2 turns så kan spelare inte anväda den om spelare har midnre än 2 turns.
            {
                Console.WriteLine("Du har inte tillräckligt turns!"); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
            else
            {
                target.HP -= damage; //Om spelare har stamina så minskar den fiende hp med hjälp av damage.
                stamina -= exhaustion + 30; //Minskar stamina med exhaustion + 30.
                turn -= 2; //minskar en turn.
                points += 20; //spelare får 10 points.
                Console.WriteLine("Du använde en stark attack mot en fiende. Fiende hp: "+ target.HP +"."); //Information för spelare.
                Console.WriteLine("Stamina -" + exhaustion + "."); //Information för spelare.
                Console.WriteLine(""); //Information för spelare.
            }
        }
        public void Vila() //Funktion för att hämta stamina.
        {
            staminaRegain = staminaGain.Next(15, 31); //StamionaRegain får värde av random stamina m,ellan 15 och 30.
            stamina += staminaRegain; //Lägger värde för stamina med hälp av stamina regain.
            turn -= 1; //Minskar turns.
            points += 10; //Lägger 10 points.
            Console.WriteLine("Du vilar lite."); //Information för spelare.
            Console.WriteLine("Stamina +" + staminaRegain + "."); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
        }
        public void HealUp() //Funktion för heal.
        {
            hpRegain = hpGain.Next(10, 16); //hpGain får värde av random heal mellan 10 och 15.
            hp += hpRegain; //sätter värde på hp.
            turn -= 1; //Minskar turns.
            points += 10; //Lägger 10 points.
            Console.WriteLine("Du äter en äpple"); //Information för spelaren.
            Console.WriteLine("HP +" + hpRegain + "."); //Information för spelaren.
            Console.WriteLine(""); //Information för spelaren.
        }
        public void Chest() //Funktion för låda.
        {
            int chestChance = chest.Next(1, 3); //Chans för vad lådan innehåller.
            Console.WriteLine("Du hitade en låda och det står graits 200 points bredvid den."); //Information för spelaren.
            Console.WriteLine("*Hög risk*"); //Information för spelaren.
            Console.WriteLine("Vill du öppna den? Y/N"); //Information för spelaren.
            string chestSvar = Console.ReadLine(); //Input av spelare som chestSvar sparar.
            if(chestSvar.ToLower() == "y" && chestChance == 1) //Om spelaren vill öppna lådan och chans är 1.
            {
                hp -= 50; //Minskar hp med 50.
                Console.WriteLine("Det fanns en bomb i lådan!"); //Information för spelaren.
                Console.WriteLine("HH -50"); //Information för spelaren.
            }
            else if(chestSvar.ToLower() == "y" && chestChance == 2) //Om spelaren vill öppna lådan och chans är 2.
            {
                points += 200; //Spleare får 200 points.
                Console.WriteLine("Du fick 200 points!"); //Information för spelaren.
            }
            else if (chestSvar.ToLower() == "n") //Om spelaren vill inte öppna lådan.
            {
                if(chestChance == 1) //Om chestChance är 1.
                {
                    Console.WriteLine("Lådan hade en bomb!"); //Information för spelaren.
                }
                else if (chestChance == 2) //Om chestChance är 2.
                {
                    Console.WriteLine("Lådan hade en 200 points!"); //Information för spelaren.
                }
            }
        }
        public void SkrivaUt() //Funktion för spelare som skriver ut stats på spelaren.
        {
            Console.WriteLine("Din hp: " + hp + "."); //Information för spelaren.
            Console.WriteLine("Din stamina: " + stamina + "."); //Information för spelaren.
            Console.WriteLine(""); //Information för spelaren.
        }
        public void Spara() //Funktion som sparar spelaren points i en fil.
        {
            StreamWriter sr = new StreamWriter("Textfil.txt", true); //Skapar en fil och skriver i den.
            sr.WriteLine(points); //Skriver points i filen.
            sr.Close(); //Stänger filen.
        }
        public void Förtsätta() //Funktion om spelaren vill förtsätta.
        {
            hpRegain = hpGain.Next(10, 16); //hpGain får värde av random heal mellan 10 och 15.
            hp += hpRegain; //Ge spelare hp.
            Console.WriteLine("Du vann!"); //Information för spelaren.
            Console.WriteLine("HP +" + hpRegain + "."); //Information för spelaren.
            Console.WriteLine("Vill du förtsätta? Y/N"); //Information för spelaren.
            string förtsätta = Console.ReadLine(); //Input av spelare.
            Console.WriteLine(""); //Information för spelaren.

            if(förtsätta.ToLower() == "y") //om svar är lettercase y.
            {
                Console.WriteLine("Round 2"); //Information för spelaren.
                Console.WriteLine(""); //Information för spelaren.
                Turn = 2; // Sätter turns till två när spelare väljer att förtsätta.
            }
            else
            {
                Spara(); //sparar.
            }
        }
        public void Förlora() //Funktion om spelaren förlorar.
        { 
            Spara(); //sparar.
            Console.WriteLine("Du förlorade"); //Information för spelaren.
        }
    }
}