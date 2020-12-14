using System; 
using System.Text.RegularExpressions;

namespace Dames {
    class Pion{

        private int etat = 1;
        private char couleur;

        public Pion(int etatp, char couleurp){
            etat = etatp;
            couleur = couleurp;
        }
        public char Couleur { get { return couleur;}  set { couleur = value;} }

        public int Etat { get {return etat;} set{ etat = value;} }
        

        //renvoie vrai si le pion est mangé.
        public bool EstMange(){
            return this.etat == 0 ? true : false;  
        }

        //change l'etat du pion au moment où il se fait manger.
        public void PionManger(){
            if(this.EstMange() == true){
                etat = 0;
            }
        }
    }
}