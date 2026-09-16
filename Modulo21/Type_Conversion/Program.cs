// Erro de conversão de string para int

// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result); // Ainda é string

// Widening Conversion

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal; // casting uma variável (trocar) - explicit conversion
// Console.WriteLine($"int: {myInt}");

// Narrowing Conversion

// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// Transformar explicitamente para string

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// String para int usando parse

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// String para int usando convert (bom para arredondamentos, ao invés do parse)

// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

