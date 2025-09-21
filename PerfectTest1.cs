
using Xunit;
namespace TestProject1

{
    public class PerfectNumbersTest
    {
        [Fact]
        public void IsPerfectNumis6()
        {
            Assert.True(PerfectNumber.IsPerfect(6));

        }
        [Fact]
        public void IsPerfectNumis1()
        {
            Assert.False(PerfectNumber.IsPerfect(1));
        }
    }
}