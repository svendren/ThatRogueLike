using System;

namespace TRL{
    class Coord{

        public Coord(int x, int y){
            X = x;
            Y = y;
        }
        public int X{ get; set;}
        public int Y{ get; set;}

        public void Move(Coord move){
            X += move.X;
            Y += move.Y;
        }
    }
}