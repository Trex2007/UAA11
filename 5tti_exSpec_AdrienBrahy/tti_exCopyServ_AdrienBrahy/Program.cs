namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copy service");

            double phtcop; //nombre de copies
            double prix = 0; //le prix
            string mess; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                Console.WriteLine("combien voulez-vous de copies ?");
                phtcop = double.Parse(Console.ReadLine());

                //traitement
                copyCalcul(phtcop, prix, out mess);

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
        static void copyCalcul(double phtcop, double prix, out string mess)
        {
            double T10 = 0.1;
            double T30 = 0.09;
            double T3P = 0.08;
            if (phtcop < 11)
            {
                prix = phtcop * T10;
            }
            else if (phtcop < 31)
            {
                prix = 10 * T10;
                prix = prix + (phtcop-10) * T30;
            }
            else
            {
                prix = 10 * T10;
                prix = prix + 20 * T30;
                prix = prix + (phtcop-30) * T3P;
            }
            mess = "Pour photocopier vos " + phtcop + " photocopie(s) , cela vous coutera : " + prix;
        }
    }
}
