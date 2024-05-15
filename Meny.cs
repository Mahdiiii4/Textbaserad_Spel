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
            Console.WriteLine("4. Information.");
            
            int svar = int.Parse(Console.ReadLine()); //Tar in svart och spara den.
            Console.WriteLine("");
            return svar;
        }
    }
}