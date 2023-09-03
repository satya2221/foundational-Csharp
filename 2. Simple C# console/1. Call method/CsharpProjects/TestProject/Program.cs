Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll = dice.Next(51, 72);
Console.WriteLine(roll1);
Console.WriteLine(roll2);
Console.WriteLine(roll);
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);
