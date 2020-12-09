using System; 
using System.Collections.Generic;
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


        // partie de yohann 

        //les variables 
		public enum Case { XXXX, rien, pion, test, Dame }
		Regex numSeul = new Regex(@"^[1-4]$");
		public Case type;
	//	public Joueur Joueur;
		//public Position Pos;

		//Constructeurs
		// public Pion(Case p, Position Posp)
		// {
		// 	type = p;
		// 	Pos = Posp;

		// }
		public Pion()
		{
			type = Case.XXXX;
		}

		public Pion(Case p)
		{
			type = p;


		}
    }
}