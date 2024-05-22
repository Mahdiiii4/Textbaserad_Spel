using Textbaserad_Spel; 

Spelare spelare  = new Spelare();
Meny meny = new Meny();

List<Fiende> fiender = new List<Fiende>();
fiender.Add(new Fiende(50, 20, 25, 10));
fiender.Add(new StarkFiende(150, 90, 10, 30));

bool quit = false;
bool play = false;
bool save = false;
int i = 0;

while(!quit) 
{
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
        Console.WriteLine("Turns" + spelare.Turn);
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
            i = spelare.Förtsätta(i);
            play = false;
            save = true;
        }
        else if(spelare.HP <= 0)
        {
            i = spelare.Förlora(i);
            play = false;
            save = true;
        }
        else if(spelare.Turn < 1)
        {
            fiender[i].Attack(spelare);
            spelare.Turn = 2;
        }
    }
    if(save)
    {
        save = false;
        meny.ScoreBoard(spelare.Points);
    }
}