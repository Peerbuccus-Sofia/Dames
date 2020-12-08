// using System;
// namespace Dames
// {
//     class Deplacement
//     {
//         //choix du pion
//         public Pion choixBouger(List<Pion> possible)
// 		{
// 			//Si on peut bouger 
// 			if (possible.Count > 0)
// 			{
// 				int xchoix = 0;
// 				int count = 0;
// 				int countPos = 1;
// 				bool sxNumber = false;

// 				String choix = "   ";
// 				String sx = "";
// 				bool bon = false;
// 				count = possible.Count;
// 				while (!numSeul.Match(choix).Success || !bon || !sxNumber)
// 				{
// 					Console.WriteLine("Choisiez Ou Aller");
// 					for (int i = 0; i < possible.Count; i++)
// 					{

// 						Console.WriteLine(countPos + "  La position :" + " [" + possible[i].Pos.x + "] " + "[" + possible[i].Pos.y + " ]");

// 						countPos = i + 1;
// 					}
// 					choix = Console.ReadLine();


// 					sx = choix[0].ToString();

// 					sxNumber = int.TryParse(sx, out xchoix);
// 					if (sxNumber)
// 						xchoix = int.Parse(sx);

// 					if (xchoix == 1)
// 					{
// 						bon = true;
//                         return possible[0];
// 					}

// 					if (xchoix == 2)
// 					{
// 						if (count > 1)
// 						{
// 							if (possible[1].type == Case.rien)
// 							{
// 								bon = true;
// 								return possible[1];
// 							}
// 						}
// 					}

// 					if (xchoix == 3)
// 					{
// 						if (count > 2)
// 						{
// 							if (possible[2].type == Case.rien)
// 							{
// 								bon = true;
// 								return possible[2];
// 							}
// 						}
// 					}

// 					if (xchoix == 4)
// 					{
// 						if (count > 3)
// 						{
// 							if (possible[3].type == Case.rien)
// 							{
// 								bon = true;
// 								return possible[3];
// 							}
// 						}
// 					}
// 				}
// 			}
// 			return new Pion();
// 		}
//     }
// }