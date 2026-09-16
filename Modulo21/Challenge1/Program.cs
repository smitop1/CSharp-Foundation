// minha solução

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
double total = 0;
string message = "";

foreach (string item in values)
{
    double parse = 0;
    if (double.TryParse(item, out parse))
    {
        total += parse;
    }
    else message += item;
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

// solução microsoft

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// decimal total = 0m;
// string message = "";

// foreach (var value in values)
// {
//     decimal number; // stores the TryParse "out" value
//     if (decimal.TryParse(value, out number))
//     {
//         total += number;
//     } else
//     {
//         message += value;
//     }
// }

// Console.WriteLine($"Message: {message}");
// Console.WriteLine($"Total: {total}");