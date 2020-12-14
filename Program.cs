using System;

namespace Dames
{
    class Program
    {
        static void Main(string[] args)
        {
            Partie jeu = Partie.getInstance();
            Plateau plateau = Plateau.getInstance();
            Joueur joueur = new Joueur();
            Deplacement deplacement = new Deplacement();
            //Pion pion = new Pion();

            
                jeu.Ready();
                do {
                    joueur.changerjoueur();
                    Console.WriteLine($"C'est au tour du joueur {joueur.Player} de jouer");
                    deplacement.selectPion(joueur); 
                    plateau.AfficherDamier(jeu);
                }while(true);
            
        }
    }
}
