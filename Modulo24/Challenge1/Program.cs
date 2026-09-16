// Minha solução

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

int firstSpan = input.IndexOf("<span>");
int lastSpan = input.IndexOf("</span>");

firstSpan += 6;

quantity = "Quantity: " + input.Substring(firstSpan, (lastSpan - firstSpan));

int firstDiv = input.IndexOf("<div>");

output = input.Remove(firstDiv, 5);

int lastDiv = output.IndexOf("</div>");

output = output.Remove(lastDiv, 6);

output = "Output: " + output.Replace("&trade;", "&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);

// Solução microsoft (menos magic numbers)

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);