using System;

namespace TRL{

    class Preview{
        private char tile = ' ';
        char[,] render = new char[40,40];
        public void draw(List<Room> rooms, Hero player){
            //Clear canvas
            for (int i = 0; i < 40; i++){
                for (int j = 0; j< 40; j++){
                    render[j,i] = '▒';
                }
            }
            //draw rooms
            for(int r = 0; r < rooms.Count; r++){
                for(int i = rooms[r].pos.Y; i <= rooms[r].size.Y+rooms[r].pos.Y; i++){
                    for (int j = rooms[r].pos.X; j <= rooms[r].size.X+rooms[r].pos.X; j++){
                        if (i == rooms[r].pos.Y || j == rooms[r].pos.X || i == rooms[r].size.Y+rooms[r].pos.Y || j == rooms[r].size.X+rooms[r].pos.X){
                            tile = '█';
                        }
                        else {
                            tile = '.';
                        }
                        render[j,i] = tile;
                    }
                }
            }

        for (int i = 0; i < 40; i++){
            for (int j = 0; j< 40; j++){
                Console.Write(render[j,i]);
            }
            Console.WriteLine();
        }

            // for(int i = 0; i < stuff.Count; i++){
                
            // }

        }
    }
}
