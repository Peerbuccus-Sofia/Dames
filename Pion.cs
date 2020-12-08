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
        
        
        public bool EstMange(){
            if(this.etat == 0){
                return true;
            }
            else { return false; }
        }

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