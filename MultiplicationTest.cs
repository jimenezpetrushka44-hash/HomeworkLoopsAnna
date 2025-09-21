namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Sentinel()
        {
            Assert.True(MultiplicationAnna.IsSentinel("Q"));
        }
        [Fact]
        public void NumOptionisValid()
        {
            MultiplicationAnna.NumOption("2");
        }
    }
}