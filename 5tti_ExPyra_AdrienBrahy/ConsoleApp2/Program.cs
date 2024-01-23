namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille; //demander la taille
            int intervMin; //interval min
            int intervMax; //interval max
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {

                lireDouble("quelle est la taille de votre structure", out taille);
                lireDouble("quelle est l'interval min", out intervMin);
                lireDouble("quelle est l'interval max", out intervMax);

                // tableau
                int[] al = new int[taille];
                int[] ni = new int[taille];
                int[] np = new int[taille];

                // lecture des donnée
                alea(taille, al);
                LouP(taille, al, ni, np);

                //afficher le résultat
                Console.WriteLine(al);
                Console.WriteLine(ni);
                Console.WriteLine(np);

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
        static void alea(int taille, int[] al)
        {
            Random alea = new Random();
            for (int i = 0; i < al.Length - 1; i++)
            {
                int n = alea.Next();
            }
        }
        /// <summary>
        /// affiche et formule le 123
        /// </summary>
        /// <param name="mess"> message de sortie</param>
        static void LouP(int taille, int[] al, int[] ni, int[] np)
        {
            
        }
        static void lireDouble(string question, out int n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
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
