CountTo(5);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
}

int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

DisplayStudents(students);
DisplayStudents(new string[] { "Robert", "Vanya" });
// DisplayStudents(["Robert", "Vanya"]);

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

double pi = 3.14159;

PrintCircleArea(12);
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}"); // c ainda é 0 pois não é mudado na função, é apenas um argumento

void Multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

int[] array = { 1, 2, 3, 4, 5 };

PrintArray(array);
Clear(array);
PrintArray(array); // vai printar 0 pois arrays são tipos de referência (diferente de tipos de valores) guardados na memória. Isso faz com que seu valor seja alterado

void PrintArray(int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false); // strings são imutáveis quando passadas como argumento. Para consertar, passar apenas o bool para o método
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
