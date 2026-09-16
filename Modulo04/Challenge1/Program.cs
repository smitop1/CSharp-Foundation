// Challenge: Calculate Celsius given the current temperature in Fahrenheit

//     Select all of the code you wrote previously in the C# Code Editor and press Delete or Backspace to delete it.

//     Enter the following code in the C# Code Editor:
//     C#

//     int fahrenheit = 94;

// To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).

//     Display the result of the temperature conversion in a formatted message

//     Combine the variables with literal strings passed into a series of Console.WriteLine() commands to form the complete message.

//     When you're finished, the message should resemble the following output:
//     Output

//     The temperature is 34.444444444444444444444444447 Celsius.

int fahrenheit = 94;

decimal conversion = (fahrenheit - 32m) * (5m / 9m); // "m" é necessário para convertar os valores INT para decimal e realizar o cálculo.

Console.WriteLine("The temperature is " + conversion + " Celsius");
Console.WriteLine(conversion);
