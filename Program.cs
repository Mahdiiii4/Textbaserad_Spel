using Textbaserad_Spel; 

Spelare spelare  = new Spelare();
Meny meny = new Meny();

List<Fiende> fiender = new List<Fiende>();
fiender.Add(new Fiende(50, 20, 25, 10));
fiender.Add(new StarkFiende(150, 90, 10, 30));

bool quit = false;
bool play = false;

Random fiendeVal = new Random();

while(!quit) 
{
    int i = fiendeVal.Next(0, 2);
    switch(meny.MainMeny())
    {
        case 1:
        {
            play = true;
            break;
        }
        case 2:
        {
            meny.ScoreBoardSkriv();
            break;
        }
        case 3:
        {
            meny.Instruktioner();
            break;
        }
        case 4:
        {
            quit = true;
            break;
        }
    }
    
    while(play)
    {
        Console.WriteLine("Du har " + spelare.Turn + " turns kvar.");
        fiender[i].ShowUpText();
        switch(meny.SpelMeny()) 
        {
            case 1:
            {
                spelare.Attack(fiender[i]); 
                break;
            }
            case 2:
            {
                spelare.StarkAttack(fiender[i]);
                break;
            }
            case 3:
            {
                spelare.Vila();
                break;
            }
            case 4:
            {
                spelare.SkrivaUt();
                break;
            }
            case 5:
            {   
                play = false;
                quit = true;
                break;
            }
        }

        if(fiender[i].HP <= 0)
        {
            spelare.Förtsätta();
            play = false;
        }
        else if(spelare.HP <= 0)
        {
            spelare.Förlora();
            play = false;
        }
        else if(spelare.Turn < 1)
        {
            Console.WriteLine(fiender[i] + " attackerar.");
            fiender[i].Attack(spelare);
            spelare.Turn = 2;
        }
    }
}