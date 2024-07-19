using ClassLibrary;
using Shouldly;

namespace TestProject;

public class UnitTest
{
    [Fact]
    public void FooTest()
    {
        new Foo().Bar(0).ShouldBe(42);
    }

    [Fact]
    public void ConcatTest()
    {
        new Foo().Concat("a", "b").ShouldBe("a b");
    }
}