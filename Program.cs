using Textbaserad_Spel; 

Spelare spelare  = new Spelare();
Fiende fiende = new Fiende();
StarkFiende starkfiende = new StarkFiende(); 
Meny meny = new Meny();

Random random = new Random();
random.Next(1, 3);
List<object> objekts = new List<object>();
objekts.Add(fiende);
objekts.Add(starkfiende);

bool quit = false;
bool play = false;

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
            meny.ScoreBoard();
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
        switch(meny.SpelMeny()) 
        {
            case 1:
            {
                spelare.Attack(fiende); 
                break;
            }
            case 2:
            {
                spelare.StarkAttack(fiende);
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
                quit = true;
                break;
            }
        }

        if(fiende.HP <= 0)
        {
            Console.WriteLine("Du vann!");
            play = false;
        }
        else if(spelare.HP <= 0)
        {
            Console.WriteLine("Du förlorade");
            play = false;
        }
        else if(spelare.Turn < 1)
        {
            fiende.Attack(spelare);
        }
    }
}