using System;

namespace TRL{
    class Room{
        public Coord pos;
        public Coord size;

        public Room(Coord aPos, Coord aSize){
            pos = aPos;
            size = aSize;
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