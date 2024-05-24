using Textbaserad_Spel; 

Spelare spelare  = new Spelare(); //Skapar objekt av klassen spelare.
Meny meny = new Meny(); //Skapar objekt av klassen meny.

List<Fiende> fiender = new List<Fiende>(); //Skapar en lista för att lägga till objekt till den.
Fiende fiende = new Fiende(50, 20, 10); //Skapar objekt av fiende och ger den olika egenskaper med hjälp av konstruktor.
StarkFiende starkfiende = new StarkFiende(100, 80, 20); //Skapar objekt av starkfiende och ger den olika egenskaper med hjälp av konstruktor.
fiender.Add(fiende); //lägger fiende objekt i listan.
fiender.Add(starkfiende); //lägger fiende objekt i listan.

bool quit = false; //Jag skapar en bool har för att anväda den för spel loop. Medan den är false så körs loop.
bool play = false; //Samma sak som quit loop men den är för själva batalj i spelet.

Random fiendeVal = new Random(); //Random för fiende så att du möter olika fiende.
Random chestAppear = new Random(); //Random för låda så att du möter låda.

while(!quit) //While loop för spelet
{
    fiende.HP = 50; //Sätter värde för alla fiende till default när spelare väljer att förtsätta med batalj.
    fiende.Rage = 20; //Samma som ovan.
    starkfiende.HP = 150; //Samma som ovan.
    starkfiende.Rage = 90; //Samma som ovan.

    int i = fiendeVal.Next(0, 2); //Random för olika fiende.
    switch(meny.MainMeny()) //Switch för val i huvud meny.
    {
        case 1:
        {
            play = true; //Case 1 är för att starta spelet batalj.
            break;
        }
        case 2:
        {
            meny.ScoreBoardSkriv(); //En funktion som skriver 3 sorterade socrepoints.
            break;
        }
        case 3:
        {
            meny.Tutorial(); //En funktion som har all information som spelare behöver för att förstå spelet.
            break;
        }
        case 4:
        {
            quit = true; //Avslutar spelet.
            break;
        }
    }
    
    while(play) //While loop för batalj.
    {
        if(spelare.HP <= 0) //Check om spelare har förlorat.
        {
            spelare.Förlora();
            play = false;
        }
        Console.WriteLine("Du har " + spelare.Turn + " turns kvar."); //Ifnormation som gör spelet lättare.
        fiender[i].ShowUpText(); //Säger till vilken fiende du möter.

        switch(meny.SpelMeny())  //Switch för olika val i batalj.
        {
            case 1:
            {
                spelare.Attack(fiender[i]); //Funktion för speleare att attacekra.
                break;
            }
            case 2:
            {
                spelare.StarkAttack(fiender[i]); //Samma som ovan.
                break;
            }
            case 3:
            {
                spelare.Vila(); //Funktion för att hämta stamina.
                break;
            }
            case 4:
            {
                spelare.HealUp(); //Funktion för att hämta heal.
                break;
            }
            case 5:
            {
                spelare.SkrivaUt(); //Funktion för att skriva ut information om spelaren.
                break;
            }
            case 6:
            {   
                play = false; //Avslutar spelet.
                quit = true;
                break;
            }
        }
        if(fiender[i].HP <= 0) //Check om fiende förlorar.
        {
            spelare.Förtsätta(); //Ger val för spelare att förtsätta.
            play = false; //Går tillbaka till huvud meny.
        }
        else if(spelare.Turn < 1) //Om turns för spelare är 0 så attackera fienden dig.
        {
            fiender[i].Attack(spelare); //Funktion för fiende för att attackera spelaren.
            spelare.Turn = 2; //Reset till spelare turns.
        }
        if(chestAppear.Next(1, 5) == 1) //Chans för låda att visas
        {
            spelare.Chest(); //Funktion för chest.
        }
    }
}