using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dames {
    class Plateau {
        private char[,] plateau = new char[10,10];

        public void Damier(){
            Partie partie = new Partie();
            for(int i=0; i<this.plateau.GetLength(0); i++)// parcours chaque ligne
            { 
                if(i==0)
                {
                    Console.Write(' ');
                    Console.Write(' ');
                    for(int x=0; x<10; x++){
                        Console.Write(x);
                        Console.Write(' ');
                    }
                    Console.Write('\n');
                }
                for(int j=0;j<this.plateau.GetLength(1); j++)
                {
                    if(j==0){
                        Console.Write(i);
                        Console.Write(' '); 
                    }
                    if(j%2 == 0 && i%2 == 0){
                        Console.BackgroundColor = ConsoleColor.White;  
                        Console.ForegroundColor = ConsoleColor.Black; 
                        if(partie.Initialiser().Equals(true)){
                            if( i<4){
                                Console.ForegroundColor = ConsoleColor.Red; 
                                Console.Write('O');  
                            } 
                            else if (i>=6){
                                Console.ForegroundColor = ConsoleColor.Blue; 
                                Console.Write('O');  
                            }
                            else { 
                                Console.Write(' '); 
                            }
                        }
                    }
                    else if(i%2 != 0 && j%2 != 0){
                        Console.BackgroundColor = ConsoleColor.White; 
                        Console.ForegroundColor = ConsoleColor.Black; 
                        if(partie.Initialiser().Equals(true)){
                            if( i<4){
                            Console.ForegroundColor = ConsoleColor.Red; 
                            Console.Write('O');  
                            } 
                            else if (i>6){
                                Console.ForegroundColor = ConsoleColor.Blue; 
                                Console.Write('O');  
                            }
                            else { 
                                Console.Write(' '); 
                            }
                        }    
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(' ');   
                    } 
                    Console.Write(' ');
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" \n");  
            }
        }
    }
}