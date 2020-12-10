using System; 

namespace Dames {
    class Joueur{
        private char joueur = 'R';

        // Pion Pion;
   
        public void Joueurs(char joueur){
            this.joueur = joueur;
        }
        
        public char Player { 
            get { return joueur;}
            set { joueur = value;}
        }

        public char PlayerRed(){
            char rouge = 'R';
            Console.ForegroundColor = ConsoleColor.Red;
            return rouge;
        }

        public char PlayerBlue(){
            char bleu = 'B';
            Console.ForegroundColor = ConsoleColor.Blue;
            return bleu;
        }
        //changer la couleur du joueur        
        public void changerjoueur(){ 
            if(this.joueur.Equals(('B'))){
                this.joueur='R';
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else {
                this.joueur='B';
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        

       

        

        
    }
}