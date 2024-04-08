string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};
// Console.WriteLine("Before Randomizer");
// foreach (var item in pettingZoo)
// {
//     Console.WriteLine(item);
// }
RandomizeAnimals();
// Console.WriteLine("After Randomizer");
// foreach (var item in pettingZoo)
// {
//     Console.WriteLine(item);
// }

// string[,] group = AssignGroup();
// Console.WriteLine("School A");
// PrintGroup(group);
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

#region function
void RandomizeAnimals()
{
    Random random = new Random();
    for (int i = 0; i < pettingZoo.Length;i++)
    {
        int randomNumber = random.Next(i, pettingZoo.Length);
        string temp = pettingZoo[i];

        pettingZoo[i] = pettingZoo[randomNumber];
        pettingZoo[randomNumber] = temp;
    }
}

// set default group value to 6
string[,] AssignGroup(int groups = 6)
{
    // set array size based on groups
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = pettingZoo[start]; 
            start++; 
        }
    }
    return result;
}
void PrintGroup (string[,] groups)
{
    for (int i = 0; i < groups.GetLength(0); i++)
    {
        Console.Write($"Group {i+1}: ");
        for (int j = 0; j < groups.GetLength(1); j++)
        {
            Console.Write($"{groups[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PlanSchoolVisit(string schoolName, int groups=6)
{
    RandomizeAnimals();
    string[,] group = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group);
}
#endregion