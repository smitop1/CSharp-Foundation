string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12)); // não aparece, mas está lá

Console.WriteLine(input.PadLeft(12, '-')); // um dos overload - preenche o espaço vazio com um input
Console.WriteLine(input.PadRight(12, '-'));


//Add the Payment ID to the output
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";
var formattedLine = paymentId.PadRight(6);
//Add the payee name to the output
formattedLine += payeeName.PadRight(24);
//Add the payment amount to the output
formattedLine += paymentAmount.PadLeft(10);
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
