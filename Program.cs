using System.Text;

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

const string openDiv = "<div>";
const string closeDiv = "</div>";

//find quantity
int openingPosition = input.IndexOf(openSpan);
int closingPosition = input.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

//find new output
int openingPosition2 = input.IndexOf(openDiv);
int closingPosition2 = input.IndexOf(closeDiv);

openingPosition2 += openDiv.Length;
int length2 = closingPosition2 - openingPosition2;

quantity = input.Substring(openingPosition, length);
output = input.Substring(openingPosition2, length2);
output = output.Replace("&trade", "&reg");

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");

