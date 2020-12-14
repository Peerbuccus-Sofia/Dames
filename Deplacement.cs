using System;
using System.Collections;
namespace Dames
{
    class Deplacement
    {
        static Plateau plateau = Plateau.getInstance();
        static Partie jeu = Partie.getInstance();
        //public Case lacase;
        public void deplacement(){}
        public int ligne(){
            Console.WriteLine("Entrer le numéro de la ligne entre 0 et 9: ");
            String response = Console.ReadLine();
            int i = System.Convert.ToInt32(response);
            if(i<10){
                Console.Write(' ');
            } else {
                 do {
                    Console.WriteLine($"La ligne {i} n'existe pas, veuillez indiquer un numéro de ligne entre 0 et 9 :");
                    response = Console.ReadLine();
                    i = System.Convert.ToInt32(response);
                }  while(i>10);
            }
            return i;
        }

        public int colonne(){
            Console.WriteLine("Entrer le numéro de la colonne entre 0 et 9: ");
            String response = Console.ReadLine();
            int j = System.Convert.ToInt32(response);
            if(j<10){
                Console.Write(' ');
            }
            else {
                do{
                    Console.WriteLine($"La colonne {j} n'existe pas, veuillez indiquer un numéro de colonne entre 0 et 9");
                    response = Console.ReadLine();
                    j = System.Convert.ToInt32(response);
                }while(j>10);
            }
            return j;
        }
        public void selectPion(Joueur joueur){
                int ligne = this.ligne();
                int colonne = this.colonne();
                //char lacase = plateau.leplateau[ligne,colonne];
                Console.WriteLine(plateau.Occuper(ligne, colonne, joueur));
                // Si la case possède un pion
                if(plateau.Occuper(ligne, colonne, joueur).Equals(true)){ 
                    
                    //si le joueur est bleu
                    if(joueur.PlayerBlue() == joueur.Player){ 
                        if((ligne> 5 && ligne%2 == 0 && colonne%2 == 0) || (ligne> 5 && ligne%2 != 0 && colonne%2 !=0)) {
                            Console.WriteLine($"Vous avez selectionné le pion d'indice [{ligne},{colonne}]");
                            Console.WriteLine(plateau.leplateau[ligne,colonne]);
                        }
                        else { 
                            do {
                                Console.WriteLine("Erreur. Le déplacement est impossible.");
                                ligne = this.ligne();
                                colonne = this.colonne();
                            }while((ligne<5 && ligne%2 !=0 && colonne%2 !=0) || (ligne< 5 && ligne%2 == 0 && colonne%2 ==0));
                        }
                    }
    
                    //Si le joueur est rouge
                    else if(joueur.PlayerRed().Equals(joueur.Player)){
                            if((ligne< 4 && ligne%2 == 0 && colonne%2 == 0) || (ligne<4 && ligne%2 != 0 && colonne%2 !=0)){
                                Console.WriteLine($"Vous avez selectionné le pion d'indice [{ligne},{colonne}]");
                                Console.WriteLine(plateau.leplateau[ligne,colonne]);
                            }
                            else { 
                                do {
                                    Console.WriteLine("Erreur. Le déplacement est impossible.");
                                    ligne = this.ligne();
                                    colonne = this.colonne();
                                }while((ligne>4 && ligne%2 !=0 && colonne%2 !=0) || ((ligne>4 && ligne%2 == 0 && colonne%2 ==0)));
                            }
                    }
                    else { Console.WriteLine("erreur");}
                }
                else {
                    do {
                        Console.WriteLine($"La cellule d'indice [{ligne},{colonne}] est vide ou le pion appartient à votre adversaire.");  
                        ligne = this.ligne();
                        colonne = this.colonne();
                    }while(plateau.Occuper(ligne, colonne, joueur).Equals(false));              
                }
        }

        //liste de deplacement pour le joueur B
        public ArrayList listeDeplacement(int ligne, int colonne, Plateau plateau){
            ArrayList lesdeplacement = new ArrayList();
            //cellule choisis par le joueur
            int i= plateau.leplateau[ligne,colonne];
            if(colonne == 0){
                do {
                    colonne =+ 1;
                    if(ligne-1 == ' ' && colonne == ' '){
                        i = plateau.leplateau[ligne-1,colonne];
                    }
                    lesdeplacement.Add(i);
                }while(ligne-1 != ' ' && colonne != ' ');
                
            }
            else {
                colonne =-1 ;
                 
            }
           
            return lesdeplacement;
        }
           
        

            
        // public  int choix(int positionInit, int positionDest){
            
        // }

    }
}