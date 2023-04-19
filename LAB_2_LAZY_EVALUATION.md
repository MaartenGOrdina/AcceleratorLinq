# Lab 2 - Lazy Evaluation


## Part 1 (Setup)
1. Create a instance of `BusinessContext` with a `using` statement _(Hint 1)_
2. Insert a two new Companies with basic information using the context _(Hint 2)_

## Part 2 (Queries)
1. Create a variable that contains a LINQ query that retrieves all companies
2. Add a `foreach` that loops through the value of this variable and prints the name of each company _(Hint 3)_
3. Run the console app
4. View the executed query in the console
5. Use `.Where` in the the LINQ query in the variable to loop through the companies with `Orange` in the name _(Hint 4)_
6. Run the console app
7. View the executed query in the console
8. Copy the `foreach` created in step 4 and paste it under the foreach _(Hint 5)_
9. Run the console app
10. Count the executed queries in the console


## Part 3 (Fixing double queries)
1. Append `.ToList()` after the `.Where()` of the LINQ query _(Hint 6)_
2. Run the console app
3. Count the executed queries in the console

## Part 4 (Extra)
- Add an Extension method to `IQueryable` called `.SkipRandom` that skips a random amount of records using `.Skip` _(hint 7)_


##### Hints
###### Hint #1
```csharp
using AcceleratorLinq.Data;

using var context = new BusinessesContext();

Console.WriteLine($"Using database file: {context.DbPath}");
```

###### Hint #2
```csharp
context.Businesses.Add(new Business()
{
    Name = "Orange Company",
    Website = "https://example.com"
});

context.Businesses.Add(new Business()
{
    Name = "Green Company 2",
    Website = "https://example.com"
});

context.SaveChanges();
```

###### Hint #3
```csharp
var businesses = context.Businesses;

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}
```

###### Hint #4
```csharp
var businesses = context.Businesses.Where(b => b.Name.Contains("Orange"));

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}
```

###### Hint #5
```csharp
var businesses = context.Businesses.Where(b => b.Name.Contains("Orange"));

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}
```

###### Hint #6
```csharp
var businesses = context.Businesses.Where(b => b.Name.Contains("Orange")).ToList();

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}

foreach (var business in businesses)
{
    Console.WriteLine(business.Name); 
}
```

###### Hint #7
```csharp
public static class MyQueryableExtensions
{
    public static IQueryable<T> SkipRandom<T>(this IQueryable<T> queryable)
    {
        // return queryable with Skip applied..
    }
}
```