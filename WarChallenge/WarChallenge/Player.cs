using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarChallenge
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
    }
}