namespace _5TI_StockIP_Struct_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] adresseIP;                           // tableau contenant une adresse (4 places)
            Adresse[] toutesAdresses = new Adresse[20]; // matrice globale contenant toutes les adresses (max 20)

            //instanciation du contenu de chaque cellule du tableau
            for (int i = 0; i < 20; i++)
            {
                toutesAdresses[i] = new Adresse();
            }

            string nom;             // tableau contenant les noms des propriétaires des adresses
            uint nbAdresses = 0;                        // nombre d'adresses encodées dans le tableau des adresses
            bool fini = false;                          // booléen permettant de quitter la boucle principale en cas d'erreur
            string repUser;                             // réponse de l'utilisateur

            MethodesDuProjet mesOutils = new MethodesDuProjet();

            Console.WriteLine("Enregistrement d'adresses IP");
            Console.WriteLine("============================");

            // boucle d'encodage des adresses et des noms : tant qu'il y a de la place et que l'utilisateur le désire
            do
            {
                Console.WriteLine("\nEncodez un nom suivi de l'adresse IP associée : ");
                Console.WriteLine("------------------------------------------------");

                // on tente d'abord d'ajouter un nom : si plus de place : on sort et on avertit

                Console.WriteLine("Vueillez entrer vôtre nom");
                nom = Console.ReadLine();
                Console.WriteLine("\nEncodez maintenant l'adresse IP : ");
                Console.WriteLine("--------------------------------- ");
                mesOutils.LireAdresseIP(out adresseIP);
                mesOutils.AjouteAdresseIP(adresseIP, nom, ref nbAdresses, ref toutesAdresses);

                // reprise ?
                Console.WriteLine("\nVoulez-vous encoder une autre adresse ? (oui = O, non = autre touche)");
                repUser = Console.ReadLine().ToUpper();

            } while (!fini && repUser == "O");
            // affichage de toutes les informations adresses + noms
            Console.WriteLine("\nVoici les adresses encodées :");
            Console.WriteLine("=============================");
            Console.WriteLine(mesOutils.ConcateneTout(toutesAdresses, nbAdresses));
        }
    }
}
