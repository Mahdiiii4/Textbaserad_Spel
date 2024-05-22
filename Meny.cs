namespace Textbaserad_Spel
{
    public class Meny
    {
        public int MainMeny()
        {
            Console.WriteLine("Skriv nummer för val");
            Thread.Sleep(1000);
            Console.WriteLine("1. Spela");
            Thread.Sleep(500);
            Console.WriteLine("2. Scoreboard.");
            Thread.Sleep(500);
            Console.WriteLine("3. Instruktioner.");
            Thread.Sleep(500);
            Console.WriteLine("4. Quit");
            
            int menuSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return menuSvar;
        }
        
        public int SpelMeny()
        {
            Console.WriteLine("Skriv nummer för val");
            Thread.Sleep(1000);
            Console.WriteLine("1. Vanlig attack.");
            Thread.Sleep(500);
            Console.WriteLine("2. Stark attack.");
            Thread.Sleep(500);
            Console.WriteLine("3. Vila.");
            Thread.Sleep(500);
            Console.WriteLine("4. Stats.");
            Thread.Sleep(500);
            Console.WriteLine("5. Quit");
            
            int spelSvar = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            return spelSvar;
        }

        public void ScoreBoard()
        {
            StreamReader sr = new StreamReader("Textfil.txt", true);

            List<string> textRader = new List<string>();
            string rad = "";
            while ((rad = sr.ReadLine()) != null)
            {
                sortera.Add(rad);
            }
            sr.Close();
            Console.WriteLine("");
        }
        List<string> sortera = new List<string>();
        public void Instruktioner()
        {
            Console.WriteLine("Du kommer möta en fiende eller en stark fiende. Du har två turns varje runda för att välje bland olika val.");
            Thread.Sleep(1000);
            Console.WriteLine("Allt kostar en turn utanför stark attack som kostar två turns. Scoreboard och instruktioner kostar inget.");
            Thread.Sleep(1000);
            Console.WriteLine("Värje runda får du tillbaka 2 turns.");
            Console.WriteLine("");
        }

    }
}