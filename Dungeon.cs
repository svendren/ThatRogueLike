using System;

namespace TRL{
     class Dungeon{
        
     }

}



//         Coord origin = new Coord(0,0);
//         Coord size = new Coord(0,0);
//         int padding = 2;
//         List<Wall> walls = new List<Wall>();
//         public List<Room> rooms = new List<Room>();
//         char[,] dungeonRender;
//         public Dungeon (Coord minMaxSize, int roomCount){
//             if(minMaxSize.X > minMaxSize.Y){minMaxSize=new Coord(minMaxSize.Y,minMaxSize.X);}
//             Random rnd = new Random();
//             int wallIndex;
//             Coord roomOrigin = new Coord(0,0);
//             Coord roomSize = new Coord(rnd.Next(minMaxSize.X,minMaxSize.Y),rnd.Next(minMaxSize.X,minMaxSize.Y));
//             Wall wall = new Wall(roomOrigin,roomOrigin,' ');
//             for(int i = 0; i < roomCount; i++){
//                 rooms.Add(new Room(roomOrigin,roomSize));
//                 //prepare for next room
//                 if(wall.side != 'd') walls.Add(new Wall(roomOrigin, new Coord(roomOrigin.X+roomSize.X,roomOrigin.Y),'u'));
//                 if(wall.side != 'r') walls.Add(new Wall(roomOrigin, new Coord(roomOrigin.X,roomOrigin.Y+roomSize.Y),'l'));
//                 if(wall.side != 'u') walls.Add(new Wall(new Coord(roomOrigin.X,roomOrigin.Y+roomSize.Y),new Coord(roomOrigin.X+roomSize.X,roomOrigin.Y+roomSize.Y),'d'));
//                 if(wall.side != 'l') walls.Add(new Wall(new Coord(roomOrigin.X+roomSize.X,roomOrigin.Y),new Coord(roomOrigin.X+roomSize.X,roomOrigin.Y+roomSize.Y),'r'));
//                 wallIndex = rnd.Next(walls.Count-1);
//                 //Console.WriteLine(i+" wallIndex:"+wallIndex+" wa");
//                 wall = walls[wallIndex];
//                 walls.RemoveAt(wallIndex);
//                 if(wall.side == 'u' || wall.side == 'd'){
//                     roomOrigin = new Coord(rnd.Next(wall.start.X, wall.end.X),wall.start.Y);
//                 }
//                 else{
//                     roomOrigin = new Coord(wall.start.X, rnd.Next(wall.start.Y,wall.end.Y));
//                 }
//                 roomSize = new Coord(rnd.Next(minMaxSize.X,minMaxSize.Y),rnd.Next(minMaxSize.X,minMaxSize.Y));
//                 if(roomOrigin.X+roomSize.X>size.X)size.X=roomOrigin.X+roomSize.X;
//                 if(roomOrigin.Y+roomSize.Y>size.Y)size.Y=roomOrigin.Y+roomSize.Y;
//                 if(wall.side == 'u'){
//                     roomOrigin = new Coord(roomOrigin.X,roomOrigin.Y-roomSize.Y);
//                     if(roomOrigin.Y<origin.Y) origin.Y = roomOrigin.Y;
//                 }
//                 else if (wall.side == 'l'){
//                     roomOrigin = new Coord(roomOrigin.X-roomSize.X,roomOrigin.Y);
//                     if(roomOrigin.X<origin.X) origin.X = roomOrigin.X;
//                 }

//             }
//             size.X += Math.Abs(origin.X);
//             size.Y += Math.Abs(origin.Y);
//             origin = new Coord(0,0);
//             dungeonRender = new char[size.X+padding,size.Y+padding];
//             //muligens unødvendig
//             for (int i = 0; i < size.Y; i++){
//                 for (int j = 0; j< size.X; j++){
//                     dungeonRender[j,i] = '█';
//                 }
//             }

//             for(int r = 0; r<rooms.Count; r++){
//                 for(int i = 0; i<rooms[r].size.Y; i++){
//                     for(int j = 0; j<rooms[r].size.X; j++){
//                         dungeonRender[rooms[r].pos.X+j,rooms[r].pos.Y+i] = '.';
//                     } 
//                 }
//             }
//         }

//         public void Draw(){
//             for (int i = 0; i < size.Y; i++){
//                 for (int j = 0; j< size.X; j++){
//                     Console.Write(dungeonRender[j,i]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }

// }