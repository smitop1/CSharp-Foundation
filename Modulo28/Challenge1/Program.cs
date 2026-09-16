// Method to display email addresses

// Minha solução

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

string corporateDomain = "contoso.com";
string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(corporate[i, 0], corporate[i, 1], corporateDomain);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(external[i, 0], external[i, 1], externalDomain);
}

void DisplayEmail(string name, string surname, string domain)
{
    Console.WriteLine($"{name.Substring(0, 2).ToLower()}{surname.ToLower()}@{domain}");
}

// Solução Microsoft (mais completa e "enterprise")

string[,] corporate =
    {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

string[,] external =
{
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]); // melhor
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain); // melhor
}

void DisplayEmail(string first, string last, string domain = "contoso.com")
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}