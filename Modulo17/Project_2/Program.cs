
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

bool validEntry = false;
string? userInput = "";

while (!validEntry)
{
    userInput = Console.ReadLine()?.Trim();

    if (userInput?.ToLower() is "administrator" or "manager" or "user")
    {
        validEntry = true;
    }
    else Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
}

Console.WriteLine($"Your input value ({userInput}) has been accepted.");


// Solução Microsoft

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();