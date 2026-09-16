// Minha solução

string pangram = "The quick brown fox jumps over the lazy dog";

string[] items = pangram.Split(" ");

Console.WriteLine("Inverting order of words");

for (int i = 0; i < items.Length; i++)
{
    char[] valueArray = items[i].ToCharArray();
    Array.Reverse(valueArray);
    items[i] = new string(valueArray);
}

pangram = String.Join(" ", items);

Console.WriteLine($"Result: {pangram}");

// Solução Microsoft - Diferença que eu salvei na mesma string e eles criaram outra.

string pangram = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] message = pangram.Split(' ');

//Step 2
string[] newMessage = new string[message.Length];

// Step 3
for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

//Step 4
string result = String.Join(" ", newMessage);
Console.WriteLine(result);