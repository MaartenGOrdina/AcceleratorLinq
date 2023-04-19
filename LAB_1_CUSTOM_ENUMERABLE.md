# Lab 1 - Building a custom Enumerable


## Part 1 (Setup)

1. Create a new File called `FibonacciEnumerable` in `AcceleratorLinq.Console`
2. Create a class in this file called `FibonacciEnumerable` that implements ` IEnumerable<int>`
3. Generate the two `GetEnumerator` methods _(hint 1)_
4. Create a second class in the file called `FibonacciEnumerableEnumerator` that implements `IEnumerator<int>`
5. Generate the required fields _(hint 2)_

## Part 2 (Implementation)
1. Add two fields to `FibonacciEnumerableEnumerator` to store the last two Fibonacci numbers. Set the default value to `0` and `1`
2. Add a third field to `FibonacciEnumerableEnumerator` to store the current Fibonacci number
3. Add logic in `MoveNext` to generate the next Fibonacci number, store it in the the current fibonacci field you created`.
4. Return a boolean indicating if there is a next value. Use for example `return currentFibonacciNumber <= 21`
5. Update the `Current` property to return the value of the current Fibonacci number. (`public int Current => _currentFibonacciNumber;`)

## Part 3 (Testing)
1. Open `Program.cs`
2. Create a new instance of `FibonacciEnumerable` and store it in a variable
3. Loop through variable value with a `foreach` and print the value to the console
4. Run the Console app

## Part 4 (Extension)
1. Filter your enumerable results using `.where` to only numbers that less then 10.
2. Run the Console app

##### Hints
###### Hint #1
```
public class FibonacciEnumerable : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        return new FibonacciEnumerableEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
```

###### Hint #2
```
public class FibonacciEnumerableEnumerator : IEnumerator<int>
{
    public bool MoveNext()
    {
        throw new NotImplementedException();
    }

    public void Reset()
    {
    }

    public int Current { get; }

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}
```