using System;

namespace TRL{
    class Program{
        static void Main(String[]args){
            ConsoleKeyInfo input = new ConsoleKeyInfo();
            Hero player = new Hero(7,2);
            int turn = 0;
            player.Health = 15;
            Items[] treasures = {new Gold(new Coord(1,1),10), new Potion(new Coord(1,2),"green")};

            Dungeon level = new Dungeon();
            while (input.Key != ConsoleKey.Q){
                turn++;
                level.draw(player.position,turn,treasures);
                input = Console.ReadKey();            
                Coord movement = input.Key switch{
                    ConsoleKey.UpArrow => new Coord (0,-1),
                    ConsoleKey.DownArrow => new Coord (0,1),
                    ConsoleKey.LeftArrow => new Coord (-1,0),
                    ConsoleKey.RightArrow => new Coord (1,0),
                    _ => new Coord (0,0),
                };
                player.position.Move(movement);
            }
            Console.WriteLine("Program end...");
        }
    }
}