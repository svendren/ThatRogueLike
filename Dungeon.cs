using System;

namespace HelloWorld{

    class Dungeon{
        public int[] dimensions = {15,5};
        private char tile = ' ';
        public void draw(int heroX, int heroY, int heroHealth){
            tile = '╔';
            for (int y = 0; y<= dimensions[1]; y++){
                for (int x = 0; x <= dimensions[0]; x++){
                    tile = y switch{
                        _ when y == heroY && x == heroX => '@', 
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
