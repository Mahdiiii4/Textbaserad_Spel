namespace Textbaserad_Spel
{
    public class Meny
    {
        public int MainMeny() //Funktion för huvud meny.
        {
            Console.WriteLine("Skriv nummer för val"); //Val för spelare.
            Console.WriteLine("1. Spela"); //Val för spelare.
            Console.WriteLine("2. Scoreboard."); //Val för spelare.
            Console.WriteLine("3. Tutorial/info."); //Val för spelare.
            Console.WriteLine("4. Quit"); //Val för spelare.
            
            int menuSvar = int.Parse(Console.ReadLine()); //Input av spelare.
            Console.WriteLine(""); //information för spelare.
            return menuSvar; //Skickar tillbaka svar till huvud program.
        }
        public int SpelMeny() //Funktion för spel meny.
        {
            Console.WriteLine("Skriv nummer för val"); //Val för spelare.
            Console.WriteLine("1. Vanlig attack."); //Val för spelare.
            Console.WriteLine("2. Stark attack."); //Val för spelare.
            Console.WriteLine("3. Vila."); //Val för spelare.
            Console.WriteLine("4. Heal."); //Val för spelare.
            Console.WriteLine("5. Stats."); //Val för spelare.
            Console.WriteLine("6. Quit"); //Val för spelare.
            
            int spelSvar = int.Parse(Console.ReadLine());  //Input av spelare.
            Console.WriteLine(""); //information för spelare.
            return spelSvar; //Skickar tillbaka svar till huvud program.
        }
        public void ScoreBoardSkriv() //Funktion för att sortera points och visa de.
        {
            StreamReader sr = new StreamReader("Textfil.txt", true); //Skapar en fil läsare.

            List<int> sortera = new List<int>(); //Skapar en lista för att läga till points
            string rad = ""; //Behövs för att while loop nedan körs.
            while((rad = sr.ReadLine()) != null) //Rad blir lika med var streamreader läser. Om rad blir null så betyder det att det finns inte mer saker att läsa och while loop avslutas.
            {
                sortera.Add(int.Parse(rad)); //Lägger linjer i sortera listan.
            }
            sr.Close(); //Stänger filen.

            sortera.Sort(); //Sortera all points.
            sortera.Reverse(); //Eftersom den spara högst värde sist så måste vi reverse värde för när det skrivs sedan.
            int i = 0; //Ger färde för i.
            foreach(int nummer in sortera) //foreach metod som skriver alla värde i listan sortera.
            {
                if(i < 3) //I för vara mest 3 eftersom vi vill bara 3 största värden vilken är 0, 1 och 2 i listan.
                {
                    Console.WriteLine(nummer); //Skriver points.
                }
                i++; //Lägger 1 till i så att den avslutar när i är 2.
            }
            Console.WriteLine(""); //Information för spelare.
        }
        public void Tutorial() //Funktion som skriver information om hur spelet går till.
        {
            Console.WriteLine("Den är en förklarking om hur spelet går till så att det blir lättare för dig att förstå hur saker funkar"); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
            Console.WriteLine("Du kommer möta en fiende eller en stark fiende. Du har två turns varje runda för att välje bland olika val."); //Information för spelare.
            Console.WriteLine("När din turns är 0 så attackera fienden dig och ibland så vilar den beronde om hur mycket 'rage' den har."); //Information för spelare.
            Console.WriteLine("Attacks kostar rage för fiende och man måste anväda en turn för att fylla upp rage igen."); //Information för spelare.
            Console.WriteLine("Stamina finns för spelaren iställt för rage och man attacks kostar stamina."); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
            Console.WriteLine("Allt kostar en turn utanför 'stark attack' som kostar två turns. 'Scoreboard' och 'tutorial/info' kostar inget."); //Information för spelare.
            Console.WriteLine("Värje runda får du tillbaka 2 turns."); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
            Console.WriteLine("En 'attack' och en 'stark attack' har slumpmassigt värde mellan två nummer."); //Information för spelare.
            Console.WriteLine("Samma sak med 'vila' och 'heal'."); //Information för spelare.
            Console.WriteLine("Heal är för att få hp tillbaka och vila är för stamina"); //Information för spelare.
            Console.WriteLine("Viktigast att man ta hansyn till sin HP eller så förlårar du."); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
            Console.WriteLine("Lycka till!!!"); //Information för spelare.
            Console.WriteLine(""); //Information för spelare.
        }
    }
}