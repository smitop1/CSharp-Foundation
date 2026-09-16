int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.

int value = 0;     // value is now 0.
value = value + 1; // value is now 1.
value++;           // value is now 2.

int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// O ++ pode ser colocado antes ou depois do valor, fazendo com que
// o cálculo seja feito e apresentado antes ou depois.

int value = 1;
value++;
Console.WriteLine("First: " + value); // 2
Console.WriteLine($"Second: {value++}"); // 2
Console.WriteLine("Third: " + value); // 3
Console.WriteLine("Fourth: " + (++value)); // 4