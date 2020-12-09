using System;
namespace Dames
{
    class Deplacement
    {
        public void deplacement(){}
        public int ligne(){
            Console.WriteLine("Entrer le numéro de la ligne entre 0 et 9: ");
            String response = Console.ReadLine();
            int i = System.Convert.ToInt32(response);
            if(i<10){
                Console.Write(i);
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
            Console.WriteLine("Entrer le numéro de la colonne : ");
            String response = Console.ReadLine();
            int j = System.Convert.ToInt32(response);
            if(j<10){
                Console.Write(j);
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

        public void selectPion(Joueur joueur, Case lacase, Plateau plateau){
            int ligne = this.ligne();
            int colonne = this.colonne();
            if(lacase.Occuper().Equals(true)){ // Si la case possède un pion
                if(joueur.PlayerBlue().Equals(ConsoleColor.Blue)){ //et si le joueur est bleu
                    if(ligne> 5){
                        if(colonne%2 == 0 && colonne%2 !=0){
                            Console.WriteLine($"Vous avez selectionné le pion d'indice{ligne}, {colonne}");
                            Console.WriteLine(plateau.plateau[ligne,colonne]);
                        }
                    } else { Console.Write("Erreur");}
                }else { Console.WriteLine("Vous êtes le joueur bleu ! Vous ne pouvez pas selectionner les pions de couleur rouge");}
            }else {
                Console.Write($"La cellule d'indice {ligne}, {colonne} est vide");
            }
           
        }

        // public void checkCase(Case lacase, Joueur joueur, string couleur){
        //     if(lacase.Occuper().Equals(false)){ // si la case est libre
        //         if(joueur.PlayerBlue().Equals(ConsoleColor.Blue)){ //que le joueur est bleue
        //             if(lacase)
        //         }
        //         else{
        //             Console.WriteLine("Vous ne pouvez pas selectionner ce pion");
        //             this.ligne();
        //             this.colonne();
        //         }
        //     }
        //     else{
        //        Console.WriteLine("La case est vide");
        //     }
        // }

        public  bool choix(int positionInit, int positionDest){
            return true;
        }

    }
}