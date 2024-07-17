using ClassLibrary;
using Shouldly;

namespace TestProject;

public class UnitTest
{
    [Fact]
    public void FooTest()
    {
        new Foo().Bar().ShouldBe(42);
    }
}