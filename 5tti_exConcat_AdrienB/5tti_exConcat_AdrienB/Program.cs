namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double structure; //demander la structure
            double taille; //demander la taille
            string mess; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                lireDouble("quelle sructure voulez-vous utiliser ? \nXOX = 1 | 123 = 2", out structure);

                //traitement
                if (structure == 1)
                {
                    lireDouble("quelle est la taille de votre structure", out taille);
                    XOX(taille, out mess);
                    Console.WriteLine("- - - - - - - -");
                }
                else
                {
                    nbrs(out mess);
                    Console.WriteLine("- - - - - - - -");
                }

                //afficher le résultat
                Console.WriteLine(mess);

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui, 'N' = non ");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - -");
                }
            } while (reapeatProg == "O");
        }
        /// <summary>
        /// affiche et formule le XOX
        /// </summary>
        /// <param name="taille"> taille de la structure</param>
        /// <param name="mess"> message de sortie</param>
        static void XOX(double taille, out string mess)
        {
            mess = "";
            for (double t = taille; t > 1;  t--)
            {
                mess += "X";
                for (double i = t; i <= taille -1; i++)
                {
                    if (i == taille - 1)
                    {
                        mess += "X";
                    }
                    else
                    {
                        mess += "O";
                    }
                }
                mess += "\n";
            }
            for (double w = taille; w > 0; w--)
            {
                mess += "X";
            }
        }
        /// <summary>
        /// affiche et formule le 123
        /// </summary>
        /// <param name="mess"> message de sortie</param>
        static void nbrs(out string mess)
        {
            mess = "";
            for (int i = 0; i < 10; i++) {
                for (int k = i; k > 0; k--)
                {
                    mess += " ";
                }
                for (int j = 10 - i; j > 0; j--)
                {
                    mess += i;
                }
                mess += "\n";
            }
        }
        static void lireDouble(string question, out double n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser,out n))
            {
                Console.WriteLine("- - - - - - - -");
                Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réaltérer la question.");
                Console.WriteLine("- - - - - - - -");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
    }
}
