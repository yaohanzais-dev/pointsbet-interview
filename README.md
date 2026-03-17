# PointsBet_Backend_Online_Code_Test
This is a simple folder containing a `StringFormatter.cs` file for code enhancement.

For candidates, please follow the below points to complete the test:
- Read the `README.md` file in the root directory, which should be the same file you are reading now. :)
- Go to the `README.md` file
  - Read the comment in the `StringFormatter.cs` file
  - Follow the instructions in the comment to complete the task

Thank you for completing the code test with PointsBet.

# Yaohan Zais Submission 17/03/2026
This class basically converts all items inside the items array into String and attached the quote before and after the item name.
For example: 
items: ["item1", "item2"]
quote: "'"

would resulted in "'item1', 'item2'"

Improvement made:
1. null handling (returning empty string, this is assumption, alternatively we can throw exception)
2. using LINQ to loop through items array

Test Scenario:
1. null handling
2. every item should have quoted and comma separated
3. single item should not have trailing comma

Hot to build:
```
dotnet build ./StringFormatter
```

How to run tests:
```
dotnet test ./StringFormatter.Tests
```