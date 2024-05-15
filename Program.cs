using System.Diagnostics;
using Textbaserad_Spel; 
using System.IO;

int poäng = 0; //För att kunna spara poäng.
int turn = 2; //Så att du ska kunna göra två olika aktioner på samma turn utan att fiende Attack dig.
Random randomFiende = new Random();
int fiendeVal = randomFiende.Next(1, 3);

Spelare spelare  = new Spelare(); //Skapar objekt av spelare för att kunna ändra på hp och använda spelarens metoder.
Fiende fiende = new Fiende(); //Skapar objekt av fiende för att kunna ändra på hp och använda fiende metoder.
StarkFiende starkfiende = new StarkFiende(); //Skapar objekt av en stark fiende för att kunna ändra på hp och använda fiende metoder.
Meny meny = new Meny();

while(spelare.HP > 0) //Loop så att spelet ska funka smidigt.
{
    Console.WriteLine(fiendeVal);
    while(fiendeVal == 1 && fiende.HP > 0) //För olika fiende typ. vanlig fiende.
    {
        int svar = meny.MenyVal();

        switch(svar) //Switch för svar för en lättare kod att läsa.
        {
            case 1:
            {
                fiende.HP = spelare.Attack(fiende.HP); //Köra metoden Attack för spelare och spara fiende hp.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                poäng = poäng + 5; //När du Attackr får du 20 poäng.
                break;
            }
            case 2:
            {
                fiende.HP = spelare.StarkAttack(fiende.HP); //Skriva ut information.
                turn = turn -2; //Eftersom du har utfört en aktion så minskas turn med 1.
                break;
            }
            case 3:
            {
                spelare.Vila();
                break;
            }
            case 4:
            {
                spelare.SkrivaUt(); //Skriva ut information.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende Attack dig nu.
        {
            Console.WriteLine("Nu är det fiendens tur");
            spelare.HP = fiende.Attack(spelare.HP); //Köra metoden Attack för fiende och spara spelare hp.
            turn = 2; //Gör så att turns blir till två så att när nästa gång loopen körs den ska funkar korrekt.
        } 
    }

    while(fiendeVal == 2 && starkfiende.HP > 0) //För olika fiende typ. stark fiende.
    {
        int svar = meny.MenyVal();

        switch(svar) //Switch för svar för en lättare kod att läsa.
        {
            case 1:
            {
                starkfiende.HP = spelare.Attack(starkfiende.HP); //Köra metoden Attack för spelare och spara fiende hp.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                poäng = poäng + 10; //När du Attackr får du 20 poäng.
                break;
            }
            case 2:
            {
                fiende.HP = spelare.StarkAttack(fiende.HP); //Skriva ut information.
                turn = turn -2; //Eftersom du har utfört en aktion så minskas turn med 1.
                poäng = poäng + 20; //När du Attackr får du 20 poäng.
                break;
            }
            case 3:
            {
                spelare.Vila();
                break;
            }
            case 4:
            {
                spelare.SkrivaUt(); //Skriva ut information.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende Attack dig nu.
        {
            Console.WriteLine("Nu är det fiendens tur");
            spelare.HP = starkfiende.Attack(spelare.HP); //Köra metoden Attack för fiende och spara spelare hp.
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

StreamWriter sw = new StreamWriter("Textfil.txt");
sw.WriteLine(poäng);
sw.Close();