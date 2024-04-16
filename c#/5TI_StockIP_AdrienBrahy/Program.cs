namespace _5TI_StockIP_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methodeProjet outilPro = new methodeProjet(); // instanciation de la structure
            string reapeatProg; // information d'utilisateur pour la reprise du programme
            string[] tableNom = new string[20];
            string mess;
            int place = 0;
            int[] adresseIP = new int[4];
            int[,] MatrAdresse = new int[4, 20];
            do // boucle de reprise du programme
            {

                outilPro.LireAdresseIP(adresseIP);
                if (outilPro.AjouteAdresseIP(place, adresseIP, MatrAdresse))
                {
                    Console.WriteLine("Vôtre Adresse Ip a été ajoutée avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue lors du traitement.");
                }
                if (outilPro.AjouteNom(place, tableNom))
                {
                    Console.WriteLine("Vôtre Nom a été ajoutée avec succès !");
                }
                else
                {
                    Console.WriteLine("Une erreur est survenue lors du traitement.");
                }

                Console.WriteLine(outilPro.ConcateneAdresse(MatrAdresse, tableNom));

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