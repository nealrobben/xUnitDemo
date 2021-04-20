using Xunit;

namespace DemoProject.Main.Tests
{
    [Collection("Collection2")]
    public class Class1TestsExtra
    {
        [Fact]
        public void TestC()
        {
            var sut = new Class1();
            sut.MethodC();
        }
    }
}
