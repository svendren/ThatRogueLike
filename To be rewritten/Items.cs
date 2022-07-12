using System;

namespace TRL{
    class Item{
   
        public Item(Coord aPos){
            pos = aPos;
        }
        public char tile {get;set;}
        public Coord pos {get;set;}
    }

    class Gold : Item{
        int amount;
        public Gold(Coord aPos, int aMount):base(aPos){
            amount = aMount;
            tile = '$';
        }
    }

    class Potion : Item{
        string colour;
        public Potion(Coord aPos, string aColour):base(aPos){
            colour = aColour;
            tile = '◒';
        }
    }
}