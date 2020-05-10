using System;
using Xunit;

namespace TennisTest
{
    public class TennisTests
    {
        [Fact]
        public void Love_All()
        {
            var tennis = new Tennis();
            Assert.Equal("Love All", tennis.Score());
        }
    }
}