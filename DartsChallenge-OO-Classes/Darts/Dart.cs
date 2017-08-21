using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Hit { get; set; }
        public int BandHit { get; set; }
        // Band string variable is used only for displaying individual Throw results as "inner", "outer", or "none"
        public string Band { get; set; }
        Random random = new Random();

        public int Wedges()
        {
            return random.Next(21);
        }

        public int Bands()
        {
            return random.Next(1, 20);
        }
    }
}
