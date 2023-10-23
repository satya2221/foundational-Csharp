// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter an integer value between 5 and 10");
string? readInput;
int value = 0;
do
{
    readInput = Console.ReadLine();
    if (readInput == null || int.TryParse(readInput, out value) == false)
    {
        Console.WriteLine("Please enter an integer value");
        continue;
    }
    else if(int.TryParse(readInput, out value) == true)
    {
        value = int.Parse(readInput);
        if (value < 5 || value > 10)
        {
            Console.WriteLine($"You entered {value}. Please enter an integer value between 5 and 10");
            continue;
        }
        else
        {
            Console.WriteLine($"Your input value ({value}) has been accepted");
            break;
        }
    }
    
    
} while (true);
