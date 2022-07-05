using System;

namespace TRL{

    class Dungeon{
        public int[] dimensions = {15,5};
        private char tile = ' ';
        public void draw(Coord pos, int heroHealth, Items[] stuff){
            Console.Clear();
            tile = '╔';
            for (int y = 0; y<= dimensions[1]; y++){
                for (int x = 0; x <= dimensions[0]; x++){
                    tile = y switch{
                        _ when y == pos.Y && x == pos.X => '@', 
                        // Pretend loop av array
                        _ when stuff[0].pos.X == x && stuff[0].pos.Y == y => stuff[0].tile,
                        _ when stuff[1].pos.X == x && stuff[1].pos.Y == y => stuff[1].tile,
                        _ when y > 0 && y < dimensions[1] && x > 0 && x < dimensions[0] => ' ',
                        _ when (y == 0 || y == dimensions[1]) && x > 0 && x < dimensions[0] => '═',
                        _ when y > 0 && y < dimensions[1] && (x == 0 || x == dimensions[0]) => '║',
                        _ when y == 0 && x == 0 => '╔',
                        _ when y == 0 && x == dimensions[0] => '╗',
                        _ when y == dimensions[1] && x == 0 => '╚',
                        _ when y == dimensions[1] && x == dimensions[0] => '╝',
                        _ => ' ',
                    };
                    Console.Write(tile);
                }
                Console.WriteLine();                
            }
            Console.WriteLine("HP: "+heroHealth);
        }
    }
}
