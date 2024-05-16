using Textbaserad_Spel; 

Spelare spelare  = new Spelare();
Fiende fiende = new Fiende();
StarkFiende starkfiende = new StarkFiende(); 
Meny meny = new Meny();

bool quit = false;

while(quit == false) 
{
    switch(meny.MenyVal()) 
    {
        case 1:
        {
            fiende.HP = spelare.Attack(fiende.HP); 
            break;
        }
        case 2:
        {
            fiende.HP = spelare.StarkAttack(fiende.HP);
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
            meny.ScoreBoard();
            break;
        }
        case 6:
        {
            meny.Instruktioner();
            break;
        }
        case 7:
        {   
            quit = true;
            break;
        }
    }
}