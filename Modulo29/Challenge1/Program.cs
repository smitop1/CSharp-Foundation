Random random = new Random();


Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 7);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string readResult = "";
    do
    {

        readResult = Console.ReadLine();
        if (readResult != null)
        {
            readResult = readResult.ToLower();
        }
        while (readResult != "n" && readResult != "y") ;


    } while (readResult != "n" && readResult != "y");

    return readResult == "y";
}

string WinOrLose(int roll, int target)
{
    return (roll >= target) ? "You win!" : "You lose!";
}