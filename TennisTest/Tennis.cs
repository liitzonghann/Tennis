using System.Collections.Generic;

namespace TennisTest
{
    public class Tennis
    {
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore != _secondPlayerScore)
            {
                return LookupScore();
            }

            if (_firstPlayerScore == 1)
            {
                return "Fifteen All";
            }

            return "Love All";
        }

        private string LookupScore()
        {
            return $"{_lookupScore[_firstPlayerScore]} {_lookupScore[_secondPlayerScore]}";
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