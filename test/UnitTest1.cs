namespace WebApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var testInteger1 = 1;
        var testInteger2 = 1;
        Assert.Equal(testInteger1, testInteger2);
    }
}