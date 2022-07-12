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


    class Character{
        Random rnd = new Random();
        public Coord pos {get;set;}
        char[] sprite = new char[1];
        public Character(Coord aPos, char aSprite){
            pos = aPos;
            sprite[0]=aSprite;
        }        
        public Character(Coord aPos, char[] aSprite){
            pos = aPos;
            sprite=aSprite;
        }

        bool correctSprite;
        public char GetSprite(int frame){
            correctSprite=false;
            while(!correctSprite){
                if (frame > sprite.Length){
                    frame-=sprite.Length;
                }
                else{
                    correctSprite=true;
                }
            }
            return sprite[frame-1];
        }
        public List<Coord> OpenDir(Wall w){
            List<Coord> openSpace = new List<Coord>();
            //TODO coords
            if(!w.Check(new Coord(pos.X,pos.Y-1))) openSpace.Add(new Coord(0,-1));
            if(!w.Check(new Coord(pos.X,pos.Y+1))) openSpace.Add(new Coord(0,1));
            if(!w.Check(new Coord(pos.X-1,pos.Y))) openSpace.Add(new Coord(-1,0));
            if(!w.Check(new Coord(pos.X+1,pos.Y))) openSpace.Add(new Coord(1,0));
            return openSpace;
        }
        public bool CheckDir(Wall w, Coord at){
            if(!w.Check(at)) return false;
            return true;
        }

    }
}