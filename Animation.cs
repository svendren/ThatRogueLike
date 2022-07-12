using System;

namespace TRL{
    class Animation{
        public int frame=1;
        int finalFrame;
        int frameTime;
        public Animation(int frameCount, int timing){
            finalFrame=frameCount;
            frameTime = timing;
        }
        public void animationStart(){
            while(Program.GAMERUNNING){
                frame++;
                if(frame>finalFrame)frame=1;
                //TODO draw scene
                Console.Write("|");
                Thread.Sleep(frameTime);
            }
        }
    }
}