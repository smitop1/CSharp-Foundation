// Unit 2

// string[] pallets = ["B14", "A11", "B12", "A13"];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets); // ordena alfanumericamente
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets); // inverte a ordem
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Unit 3

// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]}");
// Array.Clear(pallets, 0, 2); // limpa, deixando no valor default do tipo (string = null),os elementos selecionados da array
// Console.WriteLine($"After: {pallets[0]}"); // está nulo, mas o compilador converte em um valor vazio para apresentar
// if (pallets[0] != null)
//     Console.WriteLine($"After: {pallets[0].ToLower()}"); // não rodaria com valores nulos (excluídos com .Clear())
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6); // redimensiona a array para ter 6 elementos (0 a 5), tem que usar ref para passar a array
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3); // também pode redimensionar para diminuir o tamanho da array (do final para o começo)
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Unit 4

string value = "abc123";
char[] valueArray = value.ToCharArray(); // cria uma array de caracteres a partir de uma string
Array.Reverse(valueArray); // inverte a ordem desta array
// string result = new string(valueArray); // transforma a array novamente em string
string result = String.Join(",", valueArray); //  junta em uma string os valores char de uma array
Console.WriteLine(result);

string[] items = result.Split(','); // divide uma string em um array através de um separador, neste caso ","
foreach (string item in items)
{
    Console.WriteLine(item);
}
