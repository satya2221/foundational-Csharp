// See https://aka.ms/new-console-template for more information
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine($"Your have {daysUntilExpiration} day to expiration");  
if (daysUntilExpiration <=10 && daysUntilExpiration > 5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");    
}
else if (daysUntilExpiration <=5 && daysUntilExpiration > 1)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration==1)
{
    Console.WriteLine("Your subscription will expire in a day.");
    discountPercentage = 20;
}
else if (daysUntilExpiration==0)
{
    Console.WriteLine("Your subscription has expired.");
}

if (discountPercentage!=0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}

