// See https://aka.ms/new-console-template for more information
Random coins = new Random();
int coin = coins.Next(0, 2);
Console.WriteLine($"Coin: {(coin == 0 ? "Heads" : "Tails")}");
