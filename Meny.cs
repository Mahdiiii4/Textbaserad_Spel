namespace Textbaserad_Spel
{
    public class Meny
    {
        public int MainMeny()
        {
            Console.WriteLine("Skriv nummer för val");
            Console.WriteLine("1. Spela");
            Console.WriteLine("2. Scoreboard.");
            Console.WriteLine("3. Instruktioner.");
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
            Console.WriteLine("4. Stats.");
            Console.WriteLine("5. Quit");
            
            int spelSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return spelSvar;
        }

        public void ScoreBoard()
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
        public void Instruktioner()
        {
            Console.WriteLine("Du kommer möta en fiende eller en stark fiende. Du har två turns varje runda för att välje bland olika val.");
            Console.WriteLine("Allt kostar en turn utanför stark attack som kostar två turns. Scoreboard och instruktioner kostar inget.");
            Console.WriteLine("Värje runda får du tillbaka 2 turns.");
            Console.WriteLine("");
        }

    }
}