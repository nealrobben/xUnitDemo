using Xunit;

namespace DemoProject.Main.Tests
{
    [Collection("Collection2")]
    public class Class1TestsExtra
    {
        [Fact]
        public void TestThree()
        {
            var sut = new Class1();
            sut.ThirdTest();
        }
    }
}
