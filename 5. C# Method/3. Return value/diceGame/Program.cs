Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string playTheGame = Console.ReadLine();
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = CallRandomNumber();
        var roll = CallRandomNumber();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");
        playTheGame = Console.ReadLine();
        play = ShouldPlay();
    }
}

int CallRandomNumber()
{
    return random.Next(0, 7);
}

string WinOrLose(int target, int roll)
{
    if (roll > target)
    {
        return "You Win!";
    }
    else
    {
        return "You Lose!";
    }
}

bool ShouldPlay(){
    if (playTheGame == "Y")
    {
        return true;
    }
    else{
        return false;
    }
}