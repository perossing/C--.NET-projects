using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DartsChallenge
{
    public class Score
    {
        public static int ThrowScore { get; set; }

        public static int CalcScore(int Hit, int BandHit)
        {
            ThrowScore = Hit;
            if (Hit == 0)
            {
                ThrowScore += 25;
                if (BandHit == 1) ThrowScore += 25;
            }
            else if (BandHit == 2) ThrowScore = Hit * 2;
            else if (BandHit == 1) ThrowScore = Hit * 3;
            return ThrowScore;
        }
    }
}