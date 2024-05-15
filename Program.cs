using System.Diagnostics;
using Textbaserad_Spel; 

int poäng = 0; //För att kunna spara poäng.
int turn = 2; //Så att du ska kunna göra två olika aktioner på samma turn utan att fiende attackera dig.

Random randomFiende = new Random();
int fiendeVal = randomFiende.Next(1, 3);

Spelare spelare  = new Spelare(); //Skapar objekt av spelare för att kunna ändra på hp och använda spelarens metoder.
Fiende fiende = new Fiende(); //Skapar objekt av fiende för att kunna ändra på hp och använda fiende metoder.
StarkFiende starkfiende = new StarkFiende(); //Skapar objekt av en stark fiende för att kunna ändra på hp och använda fiende metoder.

while(spelare.HP > 0) //Loop så att spelet ska funka smidigt.
{
    Console.WriteLine(fiendeVal);
    while(fiendeVal == 1 && fiende.HP > 0) //För olika fiende typ. vanlig fiende.
    {
        Console.WriteLine("Välj med nummer"); //Du har val mellan två olika saker. Attackera och skriva ut liv.
        Thread.Sleep(500);
        Console.WriteLine("1. Attackra");
        Thread.Sleep(500);
        Console.WriteLine("2. Skriva ut liv");
        Thread.Sleep(500);

        int svar = int.Parse(Console.ReadLine()); //Tar in svart och spara den.
        Console.WriteLine("");
        Thread.Sleep(1000);

        switch(svar) //Switch för svar för en lättare kod att läsa.
        {
            case 1:
            {
                fiende.HP = spelare.Attackera(fiende.HP); //Köra metoden attackera för spelare och spara fiende hp.
                Console.WriteLine("Du attackerade fiende. Fiende hp: "+ spelare.Attackera(fiende.HP) +".");
                Console.WriteLine("");
                Thread.Sleep(1000);
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                poäng = poäng + 5; //När du attackerar får du 20 poäng.
                break;
            }
            case 2:
            {
                spelare.SkrivaUt();
                Console.WriteLine("");
                Thread.Sleep(1000);
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende attackera dig nu.
        {
            spelare.HP = fiende.Attackera(spelare.HP); //Köra metoden attackera för fiende och spara spelare hp.
            Console.WriteLine("");
            Thread.Sleep(1000);
            turn = 2; //Gör så att turns blir till två så att när nästa gång loopen körs den ska funkar korrekt.
        } 
    }

    while(fiendeVal == 2 && starkfiende.HP > 0) //För olika fiende typ. stark fiende.
    {
        Console.WriteLine("Välj med nummer"); //Du har val mellan två olika saker. Attackera och skriva ut liv.
        Thread.Sleep(500);
        Console.WriteLine("1. Attackra");
        Thread.Sleep(500);
        Console.WriteLine("2. Skriva ut liv");
        Thread.Sleep(500);

        int svar = int.Parse(Console.ReadLine()); //Tar in svart och spara den.
        Console.WriteLine("");
        Thread.Sleep(1000);
        switch(svar) //Switch för svar för en lättare kod att läsa.
        {
            case 1:
            {
                starkfiende.HP = spelare.Attackera(starkfiende.HP); //Köra metoden attackera för spelare och spara fiende hp.
                Console.WriteLine("Du attackerade en stark fiende. Fiende hp: "+ spelare.Attackera(starkfiende.HP) +".");
                Console.WriteLine("");
                Thread.Sleep(1000);
                
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                poäng = poäng + 20; //När du attackerar får du 20 poäng.
                break;
            }
            case 2:
            {
                spelare.SkrivaUt();
                Console.WriteLine("");
                Thread.Sleep(1000);
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende attackera dig nu.
        {
            spelare.HP = starkfiende.Attackera(spelare.HP); //Köra metoden attackera för fiende och spara spelare hp.
            Console.WriteLine("");
            Thread.Sleep(1000);
            turn = 2; //Gör så att turns blir till två så att när nästa gång loopen körs den ska funkar korrekt.
        }
    }
    break;
}

if(spelare.HP > 0)
{
    Console.WriteLine("Du vann!. Din poäng är:" + poäng + ".");
}
else if (spelare.HP <= 0)
{
    Console.WriteLine("Du förlorade!. Din poäng är:" + poäng + ".");
}
