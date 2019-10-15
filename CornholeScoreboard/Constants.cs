using System;
using System.Collections.Generic;
using System.Text;

namespace CornholeScoreboard
{
    public static class Constants
    {
        public static class Intents
        {
            public const string StartGameIntent = "StartGameIntent";
            public const string ScoreGameIntent = "ScoreGameIntent";
            public const string EndGameIntent = "EndGameIntent";
            public const string GetCurrentScoreIntent = "GetCurrentScoreIntent";
        }

        public static class Responses
        {
            public const string Ok = "Ok";
        }
    }
}
