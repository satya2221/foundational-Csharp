// See https://aka.ms/new-console-template for more information
int heroHealth = 10;
int monsterHealth = 10;

Random rnd = new Random();
int attackDamage = rnd.Next(1, 10);

do
{
    monsterHealth -= attackDamage;
    Console.WriteLine($"Monster was damaged and lost {attackDamage} health and now has {monsterHealth} health.");
    
    if (monsterHealth <= 0)
        continue; 

    attackDamage = rnd.Next(1, 10);
    heroHealth -= attackDamage;
    Console.WriteLine($"Hero was damaged and lost {attackDamage} health and now has {heroHealth} health.");
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth > 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}