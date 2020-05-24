using System;
using System.Collections.Generic;

namespace TennisTest
{
    public class Tennis
    {
        private readonly string _firstPlayerName;
        private int _firstPlayerScore;

        private readonly Dictionary<int, string> _lookupScore = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };

        private int _secondPlayerScore;
        private string _secondPlayerName;

        public Tennis(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public string Score()
        {
            if (IsScoreDefferent())
            {
                if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
                {
                    if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
                    {
                        var advPlayerName = _firstPlayerScore > _secondPlayerScore
                            ? _firstPlayerName
                            : _secondPlayerName;
                        return $"{advPlayerName} Adv";
                    }
                }

                return LookupScore();
            }

            if (IsDeuce())
            {
                return Deuce();
            }

            return SameScore();
        }

        private bool IsScoreDefferent()
        {
            return _firstPlayerScore != _secondPlayerScore;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private string SameScore()
        {
            return $"{_lookupScore[_firstPlayerScore]} All";
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