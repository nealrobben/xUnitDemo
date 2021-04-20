using Xunit;

namespace DemoProject.Main.Tests
{
    [Collection("Collection1")]
    public class Class1Tests
    {
        [Fact]
        public void TestA()
        {
            var sut = new Class1();
            sut.MethodA();
        }

        [Fact]
        public void TestB()
        {
            var sut = new Class1();
            sut.MethodB();
        }
    }
}
