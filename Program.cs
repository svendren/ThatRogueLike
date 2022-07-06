using System;

namespace TRL{
    class Program{
        static void Main(String[]args){

            Dungeon level = new Dungeon(new Coord(5,10),3);
            level.Draw();
            // ConsoleKeyInfo input = new ConsoleKeyInfo();
            // Hero player = new Hero(new Coord(7,3));
            // int turn = 0;
            // player.Health = 15;
            // List<Item> treasures = new List<Item>();
            // treasures.Add(new Gold(new Coord(1,1),10));
            // treasures.Add(new Potion(new Coord(1,2),"green"));

            // Preview level = new Preview();
            // while (input.Key != ConsoleKey.Q){
            //     turn++;
            //     level.draw(player.pos,turn,treasures);
            //     Console.WriteLine("X:"+player.pos.X+" Y: "+player.pos.Y);
            //     input = Console.ReadKey();            
            //     Coord movement = input.Key switch{
            //         ConsoleKey.UpArrow => new Coord (0,-1),
            //         ConsoleKey.DownArrow => new Coord (0,1),
            //         ConsoleKey.LeftArrow => new Coord (-1,0),
            //         ConsoleKey.RightArrow => new Coord (1,0),
            //         _ => new Coord (0,0),
            //     };
            //     if(input.Key == ConsoleKey.P){
            //         treasures.RemoveAt(0);
            //     }
            //     player.pos.Move(movement);
            // }
            // Console.WriteLine("Program end...");
        }
    }
}