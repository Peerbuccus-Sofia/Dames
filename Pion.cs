using System; 
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dames {
    class Pion{

        private int etat = 1;
        private int nb_noir = 20;
        private int nb_blanc = 20 ;
        private char couleur;

        public int Nbnoir { get {return nb_noir;}}
        public int Nbblanc { get {return nb_blanc;}}

        public char Couleur { get {return couleur;}}

        public int Etat { get {return etat;}}

        // public bool PeutManger(){
        //     return true;
        // }
        
        
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

        public void LesPions(){
            Plateau pl = new Plateau();
        }

        // partie de yohann 

        //les variables 
		public enum Case { XXXX, rien, pion, test, Dame }
		Regex numSeul = new Regex(@"^[1-4]$");
		public Case type;
		public Joueur Joueur;
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