using System;

namespace HelloWorld{
    class Program{
        static void Main(String[]args){
            string input = " ";
            Hero player = new Hero(7,2);
            player.Health = 15;

            Dungeon level = new Dungeon();
            while (input != "q"){
                level.draw(player.Possition[0], player.Possition[1],player.Health);            
                input = Console.ReadLine();
                if (input == "d"){player.Possition[0]++;}
                else if (input == "a"){player.Possition[0]--;}
                else if (input == "s"){player.Possition[1]++;}
                else if (input == "w"){player.Possition[1]--;}
            }
            Console.WriteLine("Program end...");
        }
    }
}