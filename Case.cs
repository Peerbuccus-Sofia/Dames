using System;

namespace Dames {
    class Case {
        
        private int etat = 1;
        private int x;
        private int y;

        public Case(){}
        public Case (int etatp, int xp, int yp){
            etat = etatp;
            x = xp;
            y = yp;
            
        } 

        public int Etat  {get { return etat; } set { etat = value;}}
        public int X { get { return x;} set { X = value;}}
        public int Y { get { return y;} set { Y = value;}}

        public bool Occuper(){
            return (this.etat == 1) ? true : false;
        }
        

    }
}