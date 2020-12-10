using System; 

namespace Dames {
    class Dames : Pion
	{
        //fonctions 
        Joueur joueur = new Joueur();
		public bool DevenirDame(Pion[,] pla)
		{
			// if (Joueur.Couleur == Joueur.Couleurs.Blanc)
			// {
			// 	for (int i = 0; i < 9; i++)
			// 	{
			// 		if (Pos == pla[9, i].Pos)
			// 		{
			// 			pla[9, i] = new Dame(type, Pos);
			// 			return true;
			// 		}
			// 	}

			// }
			// else if (Joueur.Couleur == Joueur.Couleurs.Noir)
			// {
			// 	for (int i = 0; i < 9; i++)
			// 	{
			// 		if (Pos == pla[0, i].Pos)
			// 		{
			// 			pla[9, i] = new Dame(type, Pos);
			// 			return true;
			// 		}
			// }

			//}

			Console.WriteLine("Pas de Dame Possible");
			return false;

		}
    }
}