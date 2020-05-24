using System;
using Xunit;

namespace TennisTest
{
    public class TennisTests
    {
        private Tennis _tennis;

        public TennisTests()
        {
            _tennis = new Tennis("Joey");
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

        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        [Fact]
        public void Love_Fifteen()
        {
            _tennis.SecondPlayerScore();
            ScoreShouldBe("Love Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Love Thirty");
        }

        [Fact]
        public void Fifteen_All()
        {
            GivenFirstPlayerScore(1);
            GivenSecondPlayerScore(1);
            ScoreShouldBe("Fifteen All");
        }

        [Fact]
        public void Thirty_All()
        {
            GivenFirstPlayerScore(2);
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Thirty All");
        }

        [Fact]
        public void Deuce()
        {
            GivenDeuce();
            ScoreShouldBe("Deuce");
        }

        [Fact]
        public void FirstPlayer_Adv()
        {
            GivenDeuce();
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Joey Adv");
        }

        private void GivenDeuce()
        {
            GivenFirstPlayerScore(3);
            GivenSecondPlayerScore(3);
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.Equal(expected, _tennis.Score());
        }
    }
}