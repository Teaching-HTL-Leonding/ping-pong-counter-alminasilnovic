//Aufgaben:
//Spielemode abfragen
//Antworten können entweder short, double oder regular sein. >>> switch
//Der Unterschied zwischen den Spielemodes sind die Anzahl der MaximalSätze.
//Fragen ob player 1 oder player 2 gewonnen hat; daraufhin einen Punkt dazu zählen >>> if, point++
//Nach jedem Punkt wird der Punktestand ausgegeben >>> points1 : points 2 IN der Schleife
// Games: 0 : 0 und Points: 0 : 0
//Dies wird wiederholt SOLANGE player 1 nicht gleich die 11 Punkte erreicht hat und player 2 nicht gleich die 11 Punkte erreicht hat.
//Nach jedem Satz müssen die Punkte erneut auf 0 gesetzt werden da die points Schleife wieder beginnt; auch im echten Tennis beginnt man Punkte immer von 0 zu zählen.
//Ein Satz zu player 1 oder player 2 dazugezählt SOLANGE player 1 und player 2 nicht die MaximalSätze erreicht haben.
//Wer die meisten Sätze hat, gewinnt; wird ganz am Ende ausgegeben.



Console.Clear();

const string POINTS = "Points: ";
const string COLON = " : ";
const string GAMES = "Games: ";
const string PLAYER1_WINS = "Congrats, Player 1 won!";
const string PLAYER2_WINS = "Congrats, Player 2 won!";
int MaximalSätze = 0;
int points1 = 0;
int points2 = 0;
int games1 = 0;
int games2 = 0;

Console.WriteLine("Gamemode?");
string gamemode = Console.ReadLine()!;


switch (gamemode)
{
    case "short":
        MaximalSätze += 1;
        break;
    case "double":
        MaximalSätze += 3;
        break;
    case "regular":
        MaximalSätze += 4;
        break;
}


do
{
    do
    {
        Console.WriteLine("Who has won? 1 or 2");
        string winner = Console.ReadLine()!;

        if (winner == "1")
        {
            points1++;
        }
        else
        {
            points2++;
        }
        Console.WriteLine(POINTS + points1 + COLON + points2);
    }
    while (points1 != 11 && points2 != 11);


    if (points1 == 11)
    {
        games1++;
    }
    else if (points2 == 11)
    {
        games2++;
    }
    points1 = 0;
    points2 = 0;
    Console.WriteLine(GAMES + games1 + COLON + games2);
}
while (games1 != MaximalSätze && games2 != MaximalSätze);


if (games1 > games2)
{
    Console.WriteLine(PLAYER1_WINS);
}

else
{
    Console.WriteLine(PLAYER2_WINS);
}



Console.WriteLine("Press any key to exit");
Console.ReadKey();
Console.Clear();