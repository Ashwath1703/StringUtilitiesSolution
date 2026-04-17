using StringUtilities;

string[] testStrings = { "Hello", "world", "Canada", "devops", "Ashwath" };

foreach (var s in testStrings)
{
    Console.WriteLine($"\"{s}\" starts with uppercase: {s.StartsWithUpperCase()}");
}