namespace _5tti_ProETfct_adrienbrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille; //nombre de chiffre que l'utilisateur veut
            string reapeatProg; // information d'utilisateur pour la reprise du programme
            string mess; 
            int[] Tal; //tableau de taille 'taille' edt rempli aleatoirement
            methodeDuProject outilPro = new methodeDuProject(); // isntanciation d ela structure

            do // boucle de reprise du programe
            {

                // lecture des donnée
                outilPro.lireInt("Combien de valeurs désirez-vous", out taille);

                //traitement
                outilPro.TblAl(taille, out Tal);
                mess = outilPro.conc(Tal);

                //afficher le résultat
                Console.WriteLine(mess);

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - -");
                }
            } while (reapeatProg == "O");
        }
    }
}