using System; 

namespace Dames {
    class Partie{

        private int initialiser = 1;

        public void LaPartie(int init){
            initialiser = init;
        }

        public int init{ get { return initialiser;}}

        public void partie(){
        }

        public bool Initialiser(){
            return (this.initialiser == 1) ? true : false;
        }
    }
}