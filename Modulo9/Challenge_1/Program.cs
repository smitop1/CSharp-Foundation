/*
 Code challenge - Report the Order IDs that need further investigation

Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". 
This will be used by the fraud team to investigate further.
*/

string[] ordersIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string iDs in ordersIDs)
{
    if (iDs.StartsWith("B"))
    {
        Console.WriteLine($"Possible fraudulent ID detected: {iDs}");
    }
}