// Finds 2 coins whose sum is equal to the target
int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;
    for (int i=0; i<coins.Length; i++)
    {
        for(int j=i+1; j<coins.Length; j++)
        {
            if(coins[i] + coins[j] == target)
            {
                result[count,0] = i;
                result[count,1] = j;
                count++;
            }
            if(count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0]:result;
}

int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found with combination from element:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}