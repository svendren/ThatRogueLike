using System;

namespace TRL{
    public class Program{
            public static bool GAMERUNNING = true;

        static void Main(String[]args){
            ConsoleKeyInfo input = new ConsoleKeyInfo();
            //Animation setup
            Animation animation = new Animation(4,500);
            Thread animationThread = new Thread(new ThreadStart(animation.animationStart));
            animationThread.Start();
            //VERY TEMP:
            char inputHolder = ' ';

            //gameloop
            while(GAMERUNNING){
                input = Console.ReadKey();            
                inputHolder = input.Key switch{
                    ConsoleKey.Q => 'q',
                    _ => ' ',
                };
                Console.WriteLine("yo");
                if (inputHolder == 'q') GAMERUNNING = false; 
            }
        }
    }
}