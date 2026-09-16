int[] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

// Output

// --Reference Types--
// ref_A[0]: 5
// ref_B[0]: 5 -- ref_B fica na mesmo espaço na memória (heap) que ref_A por causa da linha int[] ref_B = ref_A;
