using System;

namespace TRL{
 class Hero{

    public Coord position = new Coord(0,0);
   
    public int Health{ get; set;}

    public Hero(){
        
    }

    public Hero(int posX, int posY){
        position = new Coord(posX,posY);
    }


    }
}