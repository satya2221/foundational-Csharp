Random dice = new Random();
int firstRoll = dice.Next(1,7);
int secondRoll = dice.Next(1,7);
int thirdRoll = dice.Next(1,7);

int totalPoin = firstRoll + secondRoll + thirdRoll;

Console.WriteLine($"Nilai dadu: {firstRoll} + {secondRoll} + {thirdRoll} = {totalPoin}");

if (firstRoll == secondRoll || firstRoll == thirdRoll || secondRoll == thirdRoll)
{
    if (firstRoll == secondRoll && secondRoll == thirdRoll)
    {
        totalPoin += 6;
        Console.WriteLine("Jackpot!!! You get extra 6 point");
    }
    totalPoin += 2;
    Console.WriteLine("Yey you get extra 2 point");
}

if (totalPoin >= 16)
{
    Console.WriteLine($"Congratulation You Won a new car with {totalPoin} point!!!");
}
else if(totalPoin >=10)
{
    Console.WriteLine($"Congratulation You Won a new laptop with {totalPoin} point!!!");
}
else if (totalPoin == 7)
{
    Console.WriteLine($"Congratulation You Won a trip with score exactly {totalPoin} point!!!");
}
else
{
    Console.WriteLine($"Congratulation You Won a kitten with {totalPoin} point!!!");
}