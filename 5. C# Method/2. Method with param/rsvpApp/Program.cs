
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
//string const externalDomain = "hayworth.com";
int count = 0;

void RSVP(string name, int partySize=1, string allergies="none", bool inviteOnly=true) 
{
    if (inviteOnly)
    {
        bool isFound = false;
        foreach (string guest in guestList)
        {
            if(guest.Equals(name))
            {
                isFound = true;
                break;
            }
        }
        if (!isFound)
        {
            Console.WriteLine($"We are sorry that {name} is not on the list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name:"Linh",allergies: "none", partySize:2, inviteOnly:false);
RSVP(name:"Tony", 1, allergies:"Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();
PrintEmail();

void PrintEmail()
{
    string[,] corporate =
    {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

    string[,] external =
    {
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    

    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        ProcessEmailCorporate(corporate[i, 0], corporate[i, 1]);
    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
        if (i == 2)
        {
            ProcessEmailExternal(external[i, 0], external[i, 1], "bing.com");
            continue;
        }
        ProcessEmailExternal(external[i, 0], external[i, 1]);
    }
}
void ProcessEmailCorporate(string firstName, string lastName)
{
    string front = firstName.Substring(0, 2);
    Console.WriteLine($"{front}{lastName}@contoso.com");
}
static void ProcessEmailExternal(string firstName, string lastName, string domain = "hayworth.com")
{
    string front = firstName.Substring(0, 2);
    Console.WriteLine($"{front}{lastName}@{domain}");
}