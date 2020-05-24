using System.Collections.Generic;

namespace TennisTest
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (_secondPlayerScore == 1)
            {
                return "Love Fifteen";
            }

            if (_firstPlayerScore > 0)
            {
                return $"{_lookupScore[_firstPlayerScore]} Love";
            }

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScore++;
        }
    }
}