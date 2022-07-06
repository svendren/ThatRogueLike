using System;

namespace TRL{
    class Room{
        public Coord pos;
        public Coord size;

        public Room(Coord aPos, Coord aSize){
            pos = aPos;
            size = aSize;
        }

        public Room(Coord aPos, Coord xMinMax, Coord yMinMax){
            Random rand = new Random();
            pos = aPos;
            size = new Coord(rand.Next(xMinMax.X,xMinMax.Y), rand.Next(yMinMax.X,yMinMax.Y));
        }
    }
    class Wall{
        public Coord start;
        public Coord end;
        public char side;

        public Wall(Coord theStart, Coord theEnd, char aSide){
            start = theStart;
            end = theEnd;
            side = aSide;
        }
    }
}