using System;

namespace TRL{
    class Items{
   
        public Items(Coord aPos){
            pos = aPos;
        }
        public char tile {get;set;}
        public Coord pos {get;set;}
    }

    class Gold : Items{
        int amount;
        public Gold(Coord aPos, int aMount):base(aPos){
            amount = aMount;
            tile = '$';
        }
    }

    class Potion : Items{
        string colour;
        public Potion(Coord aPos, string aColour):base(aPos){
            colour = aColour;
            tile = 'U';
        }
    }
}