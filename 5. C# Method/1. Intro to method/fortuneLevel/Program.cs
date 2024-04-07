Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
void tellFortune(int luckLevel)
{
    string[] fortune;
    if (luckLevel > 75)
    {
        fortune = good;
    }
    else if (luckLevel < 25)
    {
        fortune = bad;
    }
    else
    {
        fortune = neutral;
    }
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("====Random Luck Number====");
tellFortune(luck);
Console.WriteLine("====12 Luck Number====");
tellFortune(12);
Console.WriteLine("====50 Luck Number====");
tellFortune(50);
Console.WriteLine("====80 Luck Number====");
tellFortune(80);