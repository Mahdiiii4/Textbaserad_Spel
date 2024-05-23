using Textbaserad_Spel; 

Spelare spelare  = new Spelare();
Meny meny = new Meny();

List<Fiende> fiender = new List<Fiende>();
Fiende fiende = new Fiende(50, 20, 10);
StarkFiende starkfiende = new StarkFiende(100, 80, 20);
fiender.Add(fiende);
fiender.Add(starkfiende);

bool quit = false;
bool play = false;

Random fiendeVal = new Random();
Random chestAppear = new Random();

while(!quit) 
{
    fiende.HP = 50;
    fiende.Rage = 20;
    starkfiende.HP = 150;
    starkfiende.Rage = 90;

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
            meny.Tutorial();
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
        if(spelare.HP <= 0)
        {
            spelare.Förlora();
            play = false;
        }
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
                spelare.HealUp();
                break;
            }
            case 5:
            {
                spelare.SkrivaUt();
                break;
            }
            case 6:
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
        else if(spelare.Turn < 1)
        {
            Console.WriteLine(fiender[i] + " attackerar.");
            fiender[i].Attack(spelare);
            spelare.Turn = 2;
        }
        if(chestAppear.Next(1, 5) == 1)
        {
            spelare.Chest();
        }
    }
}