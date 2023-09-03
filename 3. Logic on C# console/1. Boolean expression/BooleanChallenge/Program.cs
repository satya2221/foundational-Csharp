// See https://aka.ms/new-console-template for more information
string permission = "Admin|Manager";
int level = 55;
string userRole = "staff";

if (permission.ToLower().Contains(userRole.ToLower()))
{
    if (userRole.ToLower() == "admin")
    {
        if (level > 55)
        {
            Console.WriteLine("Welcome, Super Admin user.");
        }
        else
        {
            Console.WriteLine("Welcome, Admin user.");
        }
    }
    else
    {
        if (level >= 20)
        {
            Console.WriteLine("Contact an Admin for access");
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

