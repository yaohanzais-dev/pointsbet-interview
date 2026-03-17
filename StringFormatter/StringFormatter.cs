namespace StringFormatter;

using System.Text;


/*
Improve a block of code as you see fit in C#.
You may make any improvements you see fit, for example:
    - Cleaning up code
    - Removing redundancy
    - Refactoring / simplifying
    - Fixing typos
    - Any other light-weight optimisation

This class basically converts all items inside the items array into String and attached the quote before and after the item name.
For example: 
items: ["item1", "item2"]
quote: "'"

would resulted in "'item1', 'item2'"

Improvement made:
1. null handling (returning empty string, this is assumption, alternatively we can throw exception)
2. using LINQ to loop through items array
*/
public class StringFormatter
{
    public static string ToCommaSepatatedList(string[] items, string quote)
    {
        if (items == null || !items.Any()) return string.Empty;

        return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
    }
}