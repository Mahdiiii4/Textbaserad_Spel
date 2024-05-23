namespace Textbaserad_Spel
{
    public class Meny
    {
        public int MainMeny()
        {
            Console.WriteLine("Skriv nummer för val");
            Console.WriteLine("1. Spela");
            Console.WriteLine("2. Scoreboard.");
            Console.WriteLine("3. Tutorial/info.");
            Console.WriteLine("4. Quit");
            
            int menuSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return menuSvar;
        }
        public int SpelMeny()
        {
            Console.WriteLine("Skriv nummer för val");
            Console.WriteLine("1. Vanlig attack.");
            Console.WriteLine("2. Stark attack.");
            Console.WriteLine("3. Vila.");
            Console.WriteLine("4. Heal.");
            Console.WriteLine("5. Stats.");
            Console.WriteLine("6. Quit");
            
            int spelSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return spelSvar;
        }
        public void ScoreBoardSkriv()
        {
            StreamReader sr = new StreamReader("Textfil.txt", true);

            List<int> sortera = new List<int>();
            string rad = "";
            while ((rad = sr.ReadLine()) != null)
            {
                sortera.Add(int.Parse(rad));
            }
            sr.Close();

            sortera.Sort();
            sortera.Reverse();
            int i = 0;
            foreach(int nummer in sortera)
            {
                if(i < 3)
                {
                    Console.WriteLine(nummer);
                }
                i++;
            }
            Console.WriteLine("");
        }
        public void Tutorial()
        {
            Console.WriteLine("Den är en förklarking om hur spelet går till så att det blir lättare för dig att förstå hur saker funkar");
            Console.WriteLine("");
            Console.WriteLine("Du kommer möta en fiende eller en stark fiende. Du har två turns varje runda för att välje bland olika val.");
            Console.WriteLine("När din turns är 0 så attackera fienden dig och ibland så vilar den beronde om hur mycket 'rage' den har.");
            Console.WriteLine("Attacks kostar rage för fiende och man måste anväda en turn för att fylla upp rage igen.");
            Console.WriteLine("Stamina finns för spelaren iställt för rage och man attacks kostar stamina.");
            Console.WriteLine("");
            Console.WriteLine("Allt kostar en turn utanför 'stark attack' som kostar två turns. 'Scoreboard' och 'tutorial/info' kostar inget.");
            Console.WriteLine("Värje runda får du tillbaka 2 turns.");
            Console.WriteLine("");
            Console.WriteLine("En 'attack' och en 'stark attack' har slumpmassigt värde mellan två nummer.");
            Console.WriteLine("Samma sak med 'vila' och 'heal'.");
            Console.WriteLine("Heal är för att få hp tillbaka och vila är för stamina");
            Console.WriteLine("Viktigast att man ta hansyn till sin HP eller så förlårar du.");
            Console.WriteLine("");
            Console.WriteLine("Lycka till!!!");
            Console.WriteLine("");
        }
    }
}