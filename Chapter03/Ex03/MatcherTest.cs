namespace Chapter03.Ex03
{
    using Xunit;

    public class MatcherTest
    {
        [Fact]
        public void TestMatch()
        {
            Matcher matcher = new Matcher();

            int[] expected = {10, 50, 30, 98};
            int clipLimit = 100;
            int delta = 5;

            int[] actual = {12, 55, 25, 110};

            Assert.True(matcher.Match(expected, actual, clipLimit, delta));

            actual = new[] {10, 60, 30, 98};
            Assert.False(matcher.Match(expected, actual, clipLimit, delta));

            actual = new[] {10, 50, 30};
            Assert.False(matcher.Match(expected, actual, clipLimit, delta));
        }
    }
}