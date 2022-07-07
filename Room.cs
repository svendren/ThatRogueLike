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
    bool[,] walls;
        public Wall(List<Room> rooms, Coord lvlSize){
            walls = new bool[lvlSize.X,lvlSize.Y];
            //putt i egen
            for (int i = 0; i < lvlSize.Y; i++){
                for (int j = 0; j< lvlSize.X; j++){
                    walls[j,i] = false;
                }
            }

            for(int r = 0; r < rooms.Count; r++){
                for(int i = rooms[r].pos.Y; i <= rooms[r].size.Y+rooms[r].pos.Y; i++){
                    for (int j = rooms[r].pos.X; j <= rooms[r].size.X+rooms[r].pos.X; j++){
                        if (i == rooms[r].pos.Y || j == rooms[r].pos.X || i == rooms[r].size.Y+rooms[r].pos.Y || j == rooms[r].size.X+rooms[r].pos.X){
                            walls[j,i] = true;
                        }
                    }
                }
            }
        }
        public bool Check(Coord at){
            return walls[at.X,at.Y];
        }
    }
}