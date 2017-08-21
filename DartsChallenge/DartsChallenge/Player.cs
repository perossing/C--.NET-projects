using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartsChallenge
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public void Throw(Dart dart)
        {
            dart.Hit = dart.Wedges();
            dart.BandHit = dart.Bands();

            // This if/else section is needed only to set string to display the name of the Band for each Throw
            if (dart.BandHit == 1)
                dart.Band = "inner";
            else if (dart.BandHit == 2)
                dart.Band = "outer";
            else dart.Band = "none";

            Score.CalcScore(dart.Hit, dart.BandHit);
            Points += Score.ThrowScore;
        }
    }
}