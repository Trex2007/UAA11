using _5TI_Tri2024_AdrienBrahy;
using System;
using System.Diagnostics;

namespace _5Ti_appMatrice_AdrienB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methodeProjet outilPro = new methodeProjet(); // isntanciation de la structure
            string reapeatProg; // information d'utilisateur pour la reprise du programme
            int lignesT;
            int colonnesT;
            int cbM = 0;
            int mN = 0;
            int TypeChoix = 0;
            string mess;
            int[,] matriceOne;
            int[,] matriceTwo;
            int[,] matriceRes;

            do // boucle de reprise du programe
            {
                while (cbM < 2)
                {
                    outilPro.lireInt("Combien de matrices voulez-vous ?", out cbM);
                    if (cbM < 2){
                        Console.WriteLine("Merci de choisir 2 matrices ou plus.");
                    }
                }
                
                Console.WriteLine("Choisissez les dimentions des matrices (que 2 matrices)");
                outilPro.askSize(ref mN, out lignesT, out colonnesT);
                outilPro.matricesAI(lignesT, colonnesT, out matriceOne);

                outilPro.askSize(ref mN, out lignesT, out colonnesT);
                outilPro.matricesAI(lignesT, colonnesT, out matriceTwo);

                while (TypeChoix == 0)
                {
                    outilPro.lireInt("Que voulez vous faire ? (+ = 1 | * = 2)", out TypeChoix);
                    if (TypeChoix == 0 || TypeChoix > 2)
                    {
                        Console.WriteLine("Merci de vouloir entrer 1 ou 2");
                    }
                }
                if (TypeChoix == 1)
                {
                    outilPro.matrAdd(matriceOne, matriceTwo, out matriceRes);
                } else
                {
                    outilPro.matrMult(matriceOne, matriceTwo, out matriceRes);
                }

                outilPro.matrConc(matriceRes, out mess);

                //demande de reprise
                Console.WriteLine("\nvoulez-vous recommencez 'O' = oui");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - -");
                }
            } while (reapeatProg == "O");
        }
    }
}