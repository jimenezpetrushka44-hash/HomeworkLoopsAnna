using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void SentinelValid()
        {
            Assert.True(DailyTemps.IsSentinel("Q"));
        }

        [Fact]
        public void IsValidRangeValid()
        {
            Assert.True(DailyTemps.IsValidRange(50));
        }
    }
}