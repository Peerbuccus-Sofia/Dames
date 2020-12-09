using System;

namespace Dames
{
    class Program
    {
        static void Main(string[] args)
        {

            Plateau damier = new Plateau();
            Partie jeu = new Partie();
            Joueur joueur = new Joueur();
            Deplacement deplacement = new Deplacement();
            Case lacase = new Case();

            // do {
                if(jeu.Ready()== "oui"){
                     Console.WriteLine("Commencer une partie ! ");
                    damier.Damier();
                    joueur.changerjoueur();
                    Console.WriteLine($"C'est au tour du joueur {joueur.Player} de jouer");
                    Console.ResetColor();
                    deplacement.selectPion(joueur,lacase,damier);
                }
               
                
                //damier.plateau[ligne,colonne] 
            // }
            // while();
            
        }
    }
}
