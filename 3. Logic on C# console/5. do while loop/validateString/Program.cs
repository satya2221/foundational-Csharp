// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string? roleName;

while (true)
{
    roleName = Console.ReadLine();
    if (roleName == null)
    {
        Console.WriteLine("Please enter a value");
        continue;
    }
    string roleNameProcess;
    roleNameProcess = roleName.Trim();
    roleNameProcess = roleNameProcess.ToLower();
    if (roleNameProcess == "administrator" || roleNameProcess == "manager" || roleNameProcess == "user")
    {
        Console.WriteLine($"Your input value ({roleName}) has been accepted");
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid role name");
    }

}