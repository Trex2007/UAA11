namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy service");

            double argent; //nombre d'argent a convertire
            string mess; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                Console.WriteLine("combien avez-vous d'argent ?");
                argent = double.Parse(Console.ReadLine());

                //traitement
                billets(argent, out mess);

                //afficher le résultat
                Console.WriteLine(mess);

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui, 'N' = non ");
                reapeatProg = Console.ReadLine();

            } while (reapeatProg == "O");
        }
        /// <summary>
        /// calculer le prix que couteras x photocopies
        /// </summary>
        /// <param name="phtcop"> nombre de copies </param>
        /// <param name="prix"> le prix </param>
        /// <param name="mess"> résultat a afficher </param>
        static void billets(double argent, out string mess)
        {
            int b100 = 0, b50 = 0, b10 = 0, b5 = 0 , p2 = 0, p1 = 0; //Les billets / pieces
            while (argent > 0)
            {
                if (argent > 99)
                {
                    argent -= 100;
                    b100 += 1;
                }
                else if (argent >49)
                {
                    argent -= 50;
                    b50 += 1;
                }
                else if (argent > 9)
                {
                    argent -= 10;
                    b10 += 1;
                }
                else if (argent > 4)
                {
                    argent -= 5;
                    b5 += 1;
                }
                else if (argent > 1)
                {
                    argent -= 2;
                    p2 += 1;
                }
                else
                {
                    argent -= 1;
                    p1 += 1;
                }
            }
            mess = "vous avez " + b100 + " billet de 100 | " + b50 + " billet de 50 | " + b10 + "  billet de 10 | " + b5 + " billet de 5 | " + p2 + " pieces de 2 | " + p1 + " pieces de 1.";
        }
    }
}
