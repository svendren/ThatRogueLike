using System;

namespace TRL{
    class Hero:Character{
    
        public int Health{ get; set;}

        public Hero(Coord aPos):base(aPos){
            
        }

        public void Move(Wall w, Coord dir){
            if(!CheckDir(w,new Coord(pos.X+dir.X,pos.Y+dir.Y))) pos.Move(dir);
        }
    }
}