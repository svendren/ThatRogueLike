using System;

namespace HelloWorld{
 class Hero{
    private int[] possition = new int[2];
    // private int health = 0;
    private int attStr = 0;


    public int[] Possition{
        get{ return possition; }
        set{ possition = value; }
    }

    public int Health{ get; set;}

    public Hero(){
        possition[0] = 0;
        possition[1] = 0;
    }

    public Hero(int posX, int posY){
        possition[0] = posX;
        possition[1] = posY;
    }


    }
}