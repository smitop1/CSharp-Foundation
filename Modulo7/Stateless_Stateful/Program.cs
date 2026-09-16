Random dice = new(); // Instanciando uma classe (objeto dice)
int roll = dice.Next(1, 7); // Usando o método .Next do objeto dice (classe random)
Console.WriteLine(roll); // Classe stateless (não precisa ser instanciada antes)

// Exemplo overloaded (pode passar argumentos de tipos diferentes ou parâmetros diferentes para o método)

Random dice2 = new Random();
int roll1 = dice2.Next();
int roll2 = dice2.Next(101);
int roll3 = dice2.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

