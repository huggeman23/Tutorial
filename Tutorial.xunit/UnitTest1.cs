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
        [Fact]
        public void divide()
        {
            Assert.Equal(1.1, calc("/", 5.5, 5));
        }
        [Fact]
        public void multipli()
        {
            Assert.Equal(25, calc("*", 5, 5));
        }
        [Fact]
        public void adition()
        {
            Assert.Equal(10, calc("+", 5, 5));
        }
        [Fact]
        public void subtraction()
        {
            Assert.Equal(0, calc("-", 5, 5));
        }
        [Fact]
        public void raisedby()
        {
            Assert.Equal(32, calc("^", 2, 5));
        }
        [Fact]
        public void zeroDivide()
        {
            Assert.Equal(0, calc("/", 5, 0));
        }
        [Fact]
        public void invalidFigure()
        {
            Assert.Equal(0, calc("t", 5, 9));
        }
        public double calc(string figure, double num1, double num2)
        {
            var prog = new Program();
            return prog.expetion(figure, num1, num2);
        }
    }
}