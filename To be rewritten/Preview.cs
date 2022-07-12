using System;

namespace TRL{

    class Preview{
        private char tile = ' ';
        char[,] render = new char[40,15];
        string final = "";
        public void draw(int frame, List<Room> rooms, Hero player, Enemy enemy){
            //Clear canvas
            for (int i = 0; i < 15; i++){
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
            //draw characters
            render[enemy.pos.X,enemy.pos.Y] = enemy.GetSprite(frame);
            render[player.pos.X,player.pos.Y] = player.GetSprite(frame);
            //"render" to console
            //TODO: console screen buffer
            Console.Clear();
            final = "";
            for (int i = 0; i < 15; i++){
                for (int j = 0; j< 40; j++){
                    final += render[j,i];
                }
                final += "\n";
            }
            Console.WriteLine(final);

            // for(int i = 0; i < stuff.Count; i++){
                
            // }

        }
    }
    
}
