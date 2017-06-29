using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WarChallenge
{
    public class Deck
    // Not specified in the assignment, so chose to hard code card cards since building deck programmatically ultimately boils down to hard coding a significant number of names, suits, and values, then building up deck.  Coding a limited number of cards with search & replace made more sense to me in this case, and was still easy to alter for testing. 
    {
        ///*
        public List<Card> Cards = new List<Card>()
        {
            new Card(){Name="Two of Hearts", FaceValue=2},
            new Card(){Name="Three of Hearts", FaceValue=3},
            new Card(){Name="Four of Hearts", FaceValue=4},
            new Card(){Name="Five of Hearts", FaceValue=5},
            new Card(){Name="Six of Hearts", FaceValue=6},
            new Card(){Name="Seven of Hearts", FaceValue=7},
            new Card(){Name="Eight of Hearts", FaceValue=8},
            new Card(){Name="Nine of Hearts", FaceValue=9},
            new Card(){Name="Ten of Hearts", FaceValue=10},
            new Card(){Name="Jack of Hearts", FaceValue=11},
            new Card(){Name="Queen of Hearts", FaceValue=12},
            new Card(){Name="King of Hearts", FaceValue=13},
            new Card(){Name="Ace of Hearts", FaceValue=14},
            //
            new Card(){Name="Two of Diamonds", FaceValue=2},
            new Card(){Name="Three of Diamonds", FaceValue=3},
            new Card(){Name="Four of Diamonds", FaceValue=4},
            new Card(){Name="Five of Diamonds", FaceValue=5},
            new Card(){Name="Six of Diamonds", FaceValue=6},
            new Card(){Name="Seven of Diamonds", FaceValue=7},
            new Card(){Name="Eight of Diamonds", FaceValue=8},
            new Card(){Name="Nine of Diamonds", FaceValue=9},
            new Card(){Name="Ten of Diamonds", FaceValue=10},
            new Card(){Name="Jack of Diamonds", FaceValue=11},
            new Card(){Name="Queen of Diamonds", FaceValue=12},
            new Card(){Name="King of Diamonds", FaceValue=13},
            new Card(){Name="Ace of Diamonds", FaceValue=14},
            //
            new Card(){Name="Two of Clubs", FaceValue=2},
            new Card(){Name="Three of Clubs", FaceValue=3},
            new Card(){Name="Four of Clubs", FaceValue=4},
            new Card(){Name="Five of Clubs", FaceValue=5},
            new Card(){Name="Six of Clubs", FaceValue=6},
            new Card(){Name="Seven of Clubs", FaceValue=7},
            new Card(){Name="Eight of Clubs", FaceValue=8},
            new Card(){Name="Nine of Clubs", FaceValue=9},
            new Card(){Name="Ten of Clubs", FaceValue=10},
            new Card(){Name="Jack of Clubs", FaceValue=11},
            new Card(){Name="Queen of Clubs", FaceValue=12},
            new Card(){Name="King of Clubs", FaceValue=13},
            new Card(){Name="Ace of Clubs", FaceValue=14},
            //
            new Card(){Name="Two of Spades", FaceValue=2},
            new Card(){Name="Three of Spades", FaceValue=3},
            new Card(){Name="Four of Spades", FaceValue=4},
            new Card(){Name="Five of Spades", FaceValue=5},
            new Card(){Name="Six of Spades", FaceValue=6},
            new Card(){Name="Seven of Spades", FaceValue=7},
            new Card(){Name="Eight of Spades", FaceValue=8},
            new Card(){Name="Nine of Spades", FaceValue=9},
            new Card(){Name="Ten of Spades", FaceValue=10},
            new Card(){Name="Jack of Spades", FaceValue=11},
            new Card(){Name="Queen of Spades", FaceValue=12},
            new Card(){Name="King of Spades", FaceValue=13},
            new Card(){Name="Ace of Spades", FaceValue=14},
        };
        //*/

        //TEST DECK w 3 VALUES TO FORCE MULTIPLE WARS:
        /*
        public List<Card> Cards = new List<Card>()
        {
            new Card(){Name="Two of Pizza", FaceValue=1},
            new Card(){Name="Three of Pizza", FaceValue=1},
            new Card(){Name="Four of Pizza", FaceValue=1},
            new Card(){Name="Five of Pizza", FaceValue=1},
            new Card(){Name="Six of Pizza", FaceValue=1},
            new Card(){Name="Seven of Pizza", FaceValue=2},
            new Card(){Name="Eight of Pizza", FaceValue=2},
            new Card(){Name="Nine of Pizza", FaceValue=2},
            new Card(){Name="Ten of Pizza", FaceValue=2},
            new Card(){Name="Jack of Pizza", FaceValue=2},
            new Card(){Name="Queen of Pizza", FaceValue=3},
            new Card(){Name="King of Pizza", FaceValue=3},
            new Card(){Name="Ace of Pizza", FaceValue=3},
            //
            new Card(){Name="Two of Monkeys", FaceValue=1},
            new Card(){Name="Three of Monkeys", FaceValue=1},
            new Card(){Name="Four of Monkeys", FaceValue=1},
            new Card(){Name="Five of Monkeys", FaceValue=1},
            new Card(){Name="Six of Monkeys", FaceValue=1},
            new Card(){Name="Seven of Monkeys", FaceValue=2},
            new Card(){Name="Eight of Monkeys", FaceValue=2},
            new Card(){Name="Nine of Monkeys", FaceValue=2},
            new Card(){Name="Ten of Monkeys", FaceValue=2},
            new Card(){Name="Jack of Monkeys", FaceValue=2},
            new Card(){Name="Queen of Monkeys", FaceValue=3},
            new Card(){Name="King of Monkeys", FaceValue=3},
            new Card(){Name="Ace of Monkeys", FaceValue=3},
            //
            new Card(){Name="Two of Donuts", FaceValue=1},
            new Card(){Name="Three of Donuts", FaceValue=1},
            new Card(){Name="Four of Donuts", FaceValue=1},
            new Card(){Name="Five of Donuts", FaceValue=1},
            new Card(){Name="Six of Donuts", FaceValue=1},
            new Card(){Name="Seven of Donuts", FaceValue=2},
            new Card(){Name="Eight of Donuts", FaceValue=2},
            new Card(){Name="Nine of Donuts", FaceValue=2},
            new Card(){Name="Ten of Donuts", FaceValue=2},
            new Card(){Name="Jack of Donuts", FaceValue=2},
            new Card(){Name="Queen of Donuts", FaceValue=3},
            new Card(){Name="King of Donuts", FaceValue=3},
            new Card(){Name="Ace of Donuts", FaceValue=3},
            //
            new Card(){Name="Two of Coffee", FaceValue=1},
            new Card(){Name="Three of Coffee", FaceValue=1},
            new Card(){Name="Four of Coffee", FaceValue=1},
            new Card(){Name="Five of Coffee", FaceValue=1},
            new Card(){Name="Six of Coffee", FaceValue=1},
            new Card(){Name="Seven of Coffee", FaceValue=2},
            new Card(){Name="Eight of Coffee", FaceValue=2},
            new Card(){Name="Nine of Coffee", FaceValue=2},
            new Card(){Name="Ten of Coffee", FaceValue=2},
            new Card(){Name="Jack of Coffee", FaceValue=2},
            new Card(){Name="Queen of Coffee", FaceValue=3},
            new Card(){Name="King of Coffee", FaceValue=3},
            new Card(){Name="Ace of Coffee", FaceValue=3},
        };
        */

    }

}
 