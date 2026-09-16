// Formatação (template)

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second); // o primeiro argumento é um template que será utilizado para inserir os objetos
// Console.WriteLine("{0} {0} {0}!", first, second); // os objetos são numerado começando do {0} em ordem

// Interpolação - recomendado

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

decimal price1 = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price1:C} (Save {discount:C})"); // :C para formatar em moeda de acordo com o display do Windows

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); // formata números (por padrão, duas casas decimais)
Console.WriteLine($"Measurement: {measurement:N4} units"); // formata números (até quatro casas decimais)

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); // formata porcentagem e aproxima até 2 casas decimais

decimal price2 = 67.55m;
decimal salePrice = 59.99m;

// Formatando string igual String.Format

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

// Usando interpolação e somando a string existente

yourDiscount += $"A discount of {(price2 - salePrice) / price2:P2}!";

Console.WriteLine(yourDiscount);
