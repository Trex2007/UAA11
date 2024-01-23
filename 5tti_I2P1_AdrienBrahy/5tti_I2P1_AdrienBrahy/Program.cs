namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = 0; //demander l'age de la personne.
            double perDep = 0; //demander Depuis combien de temps il a son permi
            double nbrAcc = 0; //demander son Nombre d’accident
            string mess; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                lireDouble("Quelle est vôtre age ?", out age);
                Console.WriteLine("\n");
                lireDouble("Depuis combien de temps avez-vous le permis ?", out perDep);
                Console.WriteLine("\n");
                lireDouble("Combien d'accident avez-vous deja fait ?", out nbrAcc);

                //traitement
                typeCouleur(age, perDep, nbrAcc, out mess);
                Console.WriteLine("\n");

                //afficher le résultat
                Console.WriteLine(mess);
                Console.WriteLine("\n");

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui, 'N' = non ");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - - \n");
                }
            } while (reapeatProg == "O");
        }
        /// <summary>
        /// "calculer" quelle tarif il aura.
        /// </summary>
        /// <param name="age">age de la personne.</param>
        /// <param name="perDep">Depuis combien de temps il a son permi</param>
        /// <param name="nbrAcc"> son Nombre d’accident</param>
        /// <param name="mess">résultat a afficher</param>
        static void typeCouleur(double age, double perDep, double nbrAcc, out string mess)
        {
            string couleur = "refuser"; //résultat de son niveau d'assurance en fonction de ses résultats
            if (age > 24)
            {
                if (perDep > 2)
                {
                    if (nbrAcc == 0)
                    {
                        couleur = "vert";
                    }
                    if (nbrAcc == 1)
                    {
                        couleur = "orange";
                    }
                    if (nbrAcc == 2)
                    {
                        couleur = "rouge";
                    }
                }
                if (perDep < 2)
                {
                    if (nbrAcc == 0)
                    {
                        couleur = "orange";
                    }
                    if (nbrAcc == 1)
                    {
                        couleur = "rouge";
                    }
                }
            }
            if (age < 25)
            {
                if (perDep > 2)
                {
                    if (nbrAcc == 0)
                    {
                        couleur = "orange";
                    }
                    if (nbrAcc == 1)
                    {
                        couleur = "rouge";
                    }
                }
                if (perDep < 2)
                {
                    if (nbrAcc == 0)
                    {
                        couleur = "rouge";
                    }
                    if (nbrAcc == 1)
                    {
                        couleur = "refuser";
                    }
                }
            }
            if (couleur == "refuser")
            {
                mess = "vous avez été refuser \n";
            }
            else
            {
                mess = "vous avez été accepter ! Vôtre couleur est : " + couleur + " d'ici 5ans vous passerez a la couleur supérieur (si vous n'êtes pas deja au maximum). \n";
            }
        }
        static void lireDouble(string question, out double n)
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
