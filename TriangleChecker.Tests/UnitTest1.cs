using TriangleChecker;
using Xunit;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(1, 2, 3, false)]
    [InlineData(5, 5, 5, true)]
    [InlineData(10, 1, 1, false)]
    [InlineData(6, 8, 10, true)]
    public void CanFormTriangle_TestCases(int a, int b, int c, bool expected)
    {
        bool result = Triangle.CanFormTriangle(a, b, c);
        Assert.Equal(expected, result);
    }
}
