using System;
using Xunit;

namespace Tutorial.xunit
{
    public class UnitTest1
    {
        [Fact]
        public void arrayAdition()
        {
            string[] numbers = { "1", "5,5", "4", "non valid intput should be 0" };
            var prog = new Program();
            double right = 10.5;
            Assert.Equal(right, prog.adition(numbers));
        }
        [Fact]
        public void arraySubtraction()
        {
            string[] numbers = { "1", "5,5", "4", "non valid intput should be 0" };
            var prog = new Program();
            double right = -8.5;
            Assert.Equal(right, prog.subtraction(numbers));
        }
        [Fact]
        public void onRow()
        {
            var prog = new Program();
            Assert.Equal(3.4, prog.oneRow("6.8/2"));
        }
        [Fact]
        public void onRowNotValid()
        {
            var prog = new Program();
            Assert.Equal(0, prog.oneRow("6,8/2"));
        }
       /* [Fact]
         public void weardexpect()
        {
            var prog = new Program();

            var expectedResult = Assert.Throws<ArgumentException>(() => prog.expetion("/",1,0));
            Assert.Equal("0", expectedResult.Message);
        }
        [Fact]
        public void oneexpect()
        {
            var prog = new Program();

            var expectedResult = Assert.Throws<Exception>(() => prog.oneRow("6,8/2"));
            Assert.Equal("invalid", expectedResult.Message);
        }*/
        [Theory]
        [InlineData("*", 5, 5.5, 27.5)]
        [InlineData("*", -5, -5, 25)]
        [InlineData("*", -5, 5, -25)]
        [InlineData("/", 5, 5, 1)]
        [InlineData("/", 5, 0, 0)] 
        [InlineData("/", -5, -5, 1)]
        [InlineData("/", 5, -5, -1)]
        [InlineData("-", 5, 5, 0)]
        [InlineData("-", -5, -5, 0)]
        [InlineData("+", 5, 5, 10)]
        [InlineData("+", -5, -5, -10)]
        [InlineData("^", 5, 5, 3125)]
        [InlineData("^", -5, -5,-0.00032)]
        [InlineData("^", 5, -5, 0.00032)]
        [InlineData("t", 5, 5, 0)]
         
        public void calc(string figure, double num1, double num2, double expected)
        {
            var prog = new Program();
            Assert.Equal(expected, prog.expetion(figure, num1, num2));
        }
    }
}
