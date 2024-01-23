namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taille; //demander la taille
            int[] tp = new int[0];
            string mess; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                lireDbl("quelle est la taille de votre tableau", out taille);

                //traitement
                pETi(taille, out mess);
                Console.WriteLine("- - - - - - - -");

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

        static void pETi(double taille, out string mess)
        {
            mess = "";
        }
        static void lireDbl(string question, out double n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!double.TryParse(nUser, out n))
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
