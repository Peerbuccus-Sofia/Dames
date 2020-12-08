using System;
namespace Dames
{
    class Deplacement
    {
        private string ligne(){
         Console.WriteLine("Entrer le numero de ligne");
         string response = Console.ReadLine();
         return response;
        }

        private string colonne(){
         Console.WriteLine("Entrer le numero de colonne");
         string response = Console.ReadLine();
         return response;
        }

        private void checkCase(Case case, Pion pion, string couleur){
            if(case.Occuper().Equals(true)){
                if(pion.Couleur().Equals(couleur)){
                    // f
                }else{
                    Console.WriteLine("Vous ne pouvez pas selectionner ce pion");
                    this.ligne();
                    this.colonne();
                }
            }else{
               Console.WriteLine("La case est vide");
            }
        }


        private bool choix(int positionInit int positionDest){
            if(){}
        }

    }
}
