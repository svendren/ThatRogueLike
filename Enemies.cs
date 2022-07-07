using System;

namespace TRL{
    class Enemy:Character{
        Random rnd = new Random();
    
        public int Health{ get; set;}

        public Enemy(Coord aPos):base(aPos){
            
        }

        public void Move(Wall w){
            List<Coord> dirs = OpenDir(w);
            Coord dir = dirs[rnd.Next(dirs.Count)];
            pos.Move(dir);
        }

    }
}