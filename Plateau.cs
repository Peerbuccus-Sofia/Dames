using System;

namespace Dames {
    class Plateau {
        
        private static Plateau instance = null;
        private void plateau(){}
        public static Plateau getInstance(){
            if(instance==null){
                instance = new Plateau();
            }
            return instance;
        } 
        public char[,] leplateau = new char[10,10];
        public void AfficherDamier(Partie partie){
            for(int i=0; i<this.leplateau.GetLength(0); i++)// parcours chaque ligne
            { 
                if(i==0)
                {   //afficher les indices des colonnes
                    Console.Write(' ');
                    Console.Write(' ');
                    for(int x=0; x<10; x++){
                        Console.Write(x);
                        Console.Write(' ');
                    }
                    Console.Write('\n');
                }

                for(int j=0;j<this.leplateau.GetLength(1); j++)
                {
                    if(j==0){
                        //afficher les indices les lignes
                        Console.Write(i);
                        Console.Write(' '); 
                    }
                    if((j%2 == 0 && i%2 == 0) || (i%2 != 0 && j%2 != 0)){
                        Console.BackgroundColor = ConsoleColor.White;  
                        Console.ForegroundColor = ConsoleColor.Black;
                        if(partie.Initialiser().Equals(true)){
                            if(i<4){
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(' '); 
                                this.leplateau[i,j] = 'R';
                            } 
                            else if (i>=6){
                                Console.ForegroundColor = ConsoleColor.Blue; 
                                Console.Write(' '); 
                                this.leplateau[i,j] = 'B'; 
                            }
                            else { 
                                Console.Write(' '); 
                                this.leplateau[i,j] = ' ';
                            }
                        }
                        else {
                            Console.Write(' '); 
                           this.leplateau[i,j] = ' '; 
                        } 
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(' '); 
                        this.leplateau[i,j] = ' ';
                    } 
                    Console.Write(this.leplateau[i,j]);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" \n");  
            }
        }

        public bool Occuper(int ligne, int colonne, Joueur joueur){
            return (this.leplateau[ligne, colonne] == joueur.Player)? true : false;
        }
    }
}