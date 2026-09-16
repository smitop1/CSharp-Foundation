// Ternário
// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // Colocar () para avaliar inline

