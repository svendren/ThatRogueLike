// using System;

// namespace TRL{
//     class Program{
//         static void Main(String[]args){
//             Hero player = new Hero(new Coord(10,3),new char[4]{'A','B','C','D'});
//             Enemy enemy = new Enemy(new Coord(6,3),new char[2]{'0','O'});
//             List<Room> rooms = new List<Room>();         
//             Preview level = new Preview();
//             ConsoleKeyInfo input = new ConsoleKeyInfo();
//             Animation anim = new Animation(4,500);

//             Thread animationThread = new Thread(new ThreadStart(anim.animationStart));
//             animationThread.Start();
            
//             rooms.Add(new Room(new Coord(1,1), new Coord(10,5)));
//             rooms.Add(new Room(new Coord(20,0), new Coord(8,3)));
//             Wall walls = new Wall(rooms,new Coord(40,15));

//             while (input.Key != ConsoleKey.Q){
//                 level.draw(anim.frame,rooms,player,enemy);
//                 Console.WriteLine("X:"+player.pos.X+" Y: "+player.pos.Y);
//                 input = Console.ReadKey();            
//                 Coord movement = input.Key switch{
//                     ConsoleKey.UpArrow => new Coord (0,-1),
//                     ConsoleKey.DownArrow => new Coord (0,1),
//                     ConsoleKey.LeftArrow => new Coord (-1,0),
//                     ConsoleKey.RightArrow => new Coord (1,0),
//                     _ => new Coord (0,0),
//                 };
//                 player.Move(walls,movement);
//                 enemy.Move(walls);
                
//             }
//             animationThread.Abort();
            
            
            
            
//             // int turn = 0;
//             // player.Health = 15;
//             // List<Item> treasures = new List<Item>();
//             // treasures.Add(new Gold(new Coord(1,1),10));
//             // treasures.Add(new Potion(new Coord(1,2),"green"));
//             // Console.WriteLine("Program end...");
//         }
//     }
// }