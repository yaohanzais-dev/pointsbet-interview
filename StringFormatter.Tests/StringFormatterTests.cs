namespace StringFormatter.Tests;

public class StringFormatterTests
{
    [Fact]
    public void StringFormatter_ShouldHandleNull()
    {
        String result = StringFormatter.ToCommaSepatatedList(null, "20");

        Console.WriteLine(result);
        Assert.Equal(result, "");
    }

    [Fact]
    public void StringFormatter_ShouldLoopThroughMultipleItems()
    {
        string[] items = ["item1", "item2"];
        String result = StringFormatter.ToCommaSepatatedList(items, "'");

        Assert.Equal(result, "'item1', 'item2'");
    }

    [Fact]
    public void StringFormatter_SingleItemShouldNotHaveTrailingComma()
    {
        string[] items = ["item1"];
        String result = StringFormatter.ToCommaSepatatedList(items, "'");

        Assert.Equal(result, "'item1'");
    }
}
