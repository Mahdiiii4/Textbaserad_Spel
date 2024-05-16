namespace Textbaserad_Spel
{
    public class Meny
    {
        public int MenyVal()
        {
            Console.WriteLine("Skriv nummer för val"); //Du har val mellan två olika saker. Attackera och skriva ut liv.
            Console.WriteLine("1. Vanlig attack.");
            Console.WriteLine("2. Stark attack.");
            Console.WriteLine("3. Vila.");
            Console.WriteLine("4. Stats.");
            Console.WriteLine("5. Scoreboard.");
            Console.WriteLine("6. Instruktioner.");
            
            int svar = int.Parse(Console.ReadLine()); //Tar in svart och spara den.
            Console.WriteLine("");
            return svar;
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
            Console.WriteLine("Allt kostar en turn utanför stark attack som kostar två turns. Scoreboard och instruktioner kostar inget.");
            Console.WriteLine("");
        }
    }
}