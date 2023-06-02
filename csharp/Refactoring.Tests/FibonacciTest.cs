using System.Threading;
using Xunit;

namespace Refactoring.Tests;

public class FibonacciTest {
    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 3)]
    [InlineData(4, 5)]
    [InlineData(5, 8)]
    [InlineData(45, 1836311903)]
    public void TestFibonacciNumbers(int n, int expected)
    {
        // Act
        int actual = Fibonacci.Fib(n);

        // Assert
        Assert.Equal(expected, actual);
    }
}
