using System;
namespace Dames
{
    class Deplacement
    {
        private int ligne(){
            Console.WriteLine("Entrer le numéro de la ligne : ");
            String response = Console.ReadLine();
            int i = System.Convert.ToInt32(response);
            if(i>9){
                Console.WriteLine($"La ligne {i} n'existe pas, veuillez indiquer un numéro de ligne entre 0 et 9");
                Console.Write(response);
            }
            return i;
        }

        private int colonne(){
            Console.WriteLine("Entrer le numéro de la colonne : ");
            String response = Console.ReadLine();
            int j = System.Convert.ToInt32(response);
            if(j>9){
                Console.WriteLine($"La colonne {j} n'existe pas, veuillez indiquer un numéro de colonne entre 0 et 9");
                Console.Write(response);
            }
            return j;
        }

        private void checkCase(Case lacase, Pion pion, string couleur){
            if(lacase.Occuper().Equals(true)){
               // if(pion.Couleur() == "blue"){
                    // f
                //}
                // else{
                //     Console.WriteLine("Vous ne pouvez pas selectionner ce pion");
                //     this.ligne();
                //     this.colonne();
                // }
            }
            else{
               Console.WriteLine("La case est vide");
            }
        }

        private bool choix(int positionInit, int positionDest){
            return true;
        }

    }
}