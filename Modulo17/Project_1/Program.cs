using System.IO.Pipelines;

int validNumber;

Console.WriteLine("Enter an integer between 5 and 10");

do
{
    string? userInput = Console.ReadLine();

    if (int.TryParse(userInput, out validNumber))
    {
        if (validNumber >= 5 && validNumber <= 10) break;
        else Console.WriteLine($"You entered {validNumber}. Please enter a number between 5 and 10");
    }
    else Console.WriteLine("Sorry, you entered an invalid number, please try again.");
} while (true);

Console.WriteLine($"Your input value ({validNumber}) has been accepted.");

// Sugestão Gemini - usar validEntry ao invés de do-while(true)

// bool validEntry = false; // Começa como falso
// int validNumber = 0;

// Console.WriteLine("Enter an integer between 5 and 10");

// O loop roda enquanto validEntry for false
// while (validEntry == false) 
// {
//     string? userInput = Console.ReadLine();

//     if (int.TryParse(userInput, out validNumber))
//     {
//         if (validNumber >= 5 && validNumber <= 10) 
//         {
//             validEntry = true; // Única forma de sair do loop sem o break
//         }
//         else 
//         {
//             Console.WriteLine($"You entered {validNumber}. Please enter a number between 5 and 10");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again.");
//     }
// } 

// Console.WriteLine($"Your input value ({validNumber}) has been accepted.");

// Solução Microsoft

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();