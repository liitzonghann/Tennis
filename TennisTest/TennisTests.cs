using System;
using Xunit;

namespace TennisTest
{
    public class TennisTests
    {
        private Tennis _tennis;

        public TennisTests()
        {
            _tennis = new Tennis();
        }

        [Fact]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [Fact]
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.Equal(expected, _tennis.Score());
        }
    }
}