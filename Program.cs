using Textbaserad_Spel; 

bool text = true;
int poäng = 0; //För att kunna spara poäng.
int turn = 2; //Så att du ska kunna göra två olika aktioner på samma turn utan att fiende Attack dig.
Random randomFiende = new Random(); //Skapa random.
int fiendeVal = randomFiende.Next(1, 3); //Få random nummer. 1 eller 2 och spara i fiendeVal.

Spelare spelare  = new Spelare(); //Skapar objekt av spelare för att kunna ändra på hp och använda spelarens metoder.
Fiende fiende = new Fiende(); //Skapar objekt av fiende för att kunna ändra på hp och använda fiende metoder.
StarkFiende starkfiende = new StarkFiende(); //Skapar objekt av en stark fiende för att kunna ändra på hp och använda fiende metoder.
Meny meny = new Meny();

while(spelare.HP > 0) //Loop så att spelet ska funka smidigt.
{
    while(fiendeVal == 1 && fiende.HP > 0) //För olika fiende typ. vanlig fiende.
    {
        if(text == true)
        {
            Console.WriteLine("En fiende dyker upp");
            Console.WriteLine("");
            text = false;
        }
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
                if(turn < 2)
                {
                    Console.WriteLine("En stark attack behöver två turns!");
                }
                else
                {
                    fiende.HP = spelare.StarkAttack(fiende.HP); //Skriva ut information.
                    turn = turn -2; //Eftersom du har utfört en aktion så minskas turn med 1.
                
                }
                break;
            }
            case 3:
            {
                spelare.Vila();
                turn = turn -1;
                break;
            }
            case 4:
            {
                spelare.SkrivaUt(); //Skriva ut information.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                Console.WriteLine("Du har " + turn + " turns kvar");
                break;
            }
            case 5:
            {
                meny.ScoreBoard();
                break;
            }
            case 6:
            {
                meny.Instruktioner();
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende Attack dig nu.
        {
            Console.WriteLine("Du fick 15 skada");
            spelare.HP = fiende.Attack(spelare.HP); //Köra metoden Attack för fiende och spara spelare hp.
            turn = 2; //Gör så att turns blir till två så att när nästa gång loopen körs den ska funkar korrekt.
        } 
    }

    while(fiendeVal == 2 && starkfiende.HP > 0) //För olika fiende typ. stark fiende.
    {
        if(text == true)
        {
            Console.WriteLine("En fiende dyker upp");
            Console.WriteLine("");
            text = false;
        }
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
                if(turn < 2)
                {
                    Console.WriteLine("En stark attack behöver två turns!"); //Du får inte köra den om du har bara 2 turns.
                }
                else
                {
                    fiende.HP = spelare.StarkAttack(fiende.HP); //Skriva ut information.
                    turn = turn -2; //Eftersom du har utfört en aktion så minskas turn med 1.
                }
                break;
            }
            case 3:
            {
                spelare.Vila(); //metod för att få stamina.
                turn = turn - 1;
                break;
            }
            case 4:
            {
                spelare.SkrivaUt(); //Skriva ut information.
                turn = turn -1; //Eftersom du har utfört en aktion så minskas turn med 1.
                Console.WriteLine("Du har " + turn + " turns kvar");
                break;
            }
            case 5:
            {
                meny.ScoreBoard();
                break;
            }
            case 6:
            {
                meny.Instruktioner();
                break;
            }
        }

        if (turn <= 0) //Om du har 0 turns så kan fiende Attack dig nu.
        {
            Console.WriteLine("Du fick 5 skada");
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

Console.Write("Skriv ditt namn: ");
string namn = Console.ReadLine();
StreamWriter sw = new StreamWriter("Textfil.txt", true);
sw.WriteLine(namn + ": " + poäng);
sw.Close();