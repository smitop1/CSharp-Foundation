Console.WriteLine("Hello\nWorld"); // Nova Linha
Console.WriteLine("Hello\tWorld"); // Tab
Console.WriteLine("Hello \"World\""); // Para mostrar aspas duplas
Console.WriteLine("C:\\users\\lucas"); // Para mostrar um backslash

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

Console.WriteLine(@"
    c:\source\repos    
        (this is where your code goes)"); // Verbatim, não precisa de backslashes

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Unicodes

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");