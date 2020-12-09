using System; 

namespace Dames {
    class Joueur{
        private char joueur = 'O';
   
        public void Joueurs(char joueur){
            this.joueur = joueur;
        }
        
        public char Player { 
            get { return joueur;}
            set { joueur = value;}
        }

        public char PlayerRed(){
            char rouge = 'O';
            Console.ForegroundColor = ConsoleColor.Red;
            return rouge;
        }

        public char PlayerBlue(){
            char bleu = 'O';
            Console.ForegroundColor = ConsoleColor.Blue;
            return bleu;
        }
        //changer la couleur du joueur        
        public void changerjoueur(){ 
            if(this.joueur.Equals(ConsoleColor.Blue)){
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        

       

        

        
    }
}