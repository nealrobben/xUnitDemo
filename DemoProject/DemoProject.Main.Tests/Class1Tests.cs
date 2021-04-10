using Xunit;

namespace DemoProject.Main.Tests
{
    public class Class1Tests
    {
        [Fact]
        public void TestOne()
        {
            var sut = new Class1();
            sut.FirstTest();
        }

        [Fact]
        public void TestTwo()
        {
            var sut = new Class1();
            sut.SecondTest();
        }
    }
}
