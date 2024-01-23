namespace I25T_AssurancesSol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint agePersonne;               //age de la personne.
            uint DureeObtentionPermis = 0;  //Depuis combien de temps il a son permi
            uint nbrAccident = 0;           //Nombre d’accidents
            uint nbrAnneesAnciennete;       //Nombre d'années assurées dans cette société
            string message;                 //résultat a afficher
            string reapeatProg;             //Information utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                Console.WriteLine("Bienvenue dans ce programme d'attribution de contrat d'assurance voiture.");
                Console.WriteLine("-------------------------------------------------------------------------");

                // lecture des données
                //lireEntier("Quel âge avez-vous ?", out agePersonne);
                //lireEntier("Depuis combien de temps avez-vous le permis ?", out DureeObtentionPermis);
                //lireEntier("Combien d'accidents avez-vous déjà fait ?", out nbrAccident);
                //lireEntier("Depuis combien d'années êtes-vous assuré chez nous ?", out nbrAnneesAnciennete);

                // améliorations avec vérification sur les valeurs (remplace le bloc de lecture précédent)
                
                lireEntier("Quel âge avez-vous (entre 18 et 95) ?", out agePersonne);
                while (agePersonne < 18 || agePersonne  > 95)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Donnée incohérente !");
                    lireEntier("Quel âge avez-vous (entre 18 et 95) ?", out agePersonne);
                    Console.ResetColor();
                }

                lireEntier("Depuis combien de temps avez-vous le permis ?", out DureeObtentionPermis);
                while (DureeObtentionPermis > 77 || DureeObtentionPermis > agePersonne - 18) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Donnée incohérente !");
                    lireEntier("Depuis combien de temps avez-vous le permis ?", out DureeObtentionPermis);
                    Console.ResetColor();
                } 

                // il sortira un uint => pas de problème d'avoir un nombre négatif
                lireEntier("Combien d'accidents avez-vous déjà fait ?", out nbrAccident);

                // notre société n'existe que depuis 25 ans => pas possible d'être assuré depuis plus longtemps ici
                lireEntier("Depuis combien d'années êtes-vous assuré chez nous ?", out nbrAnneesAnciennete);
                while (nbrAnneesAnciennete >= 25 || nbrAnneesAnciennete > DureeObtentionPermis)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (nbrAnneesAnciennete > DureeObtentionPermis)
                    {
                        Console.WriteLine($"Donnée incohérente vous n'avez le permis que depuis {DureeObtentionPermis} an(s) !");
                    }
                    else
                    {
                        Console.WriteLine("Nous n'existons que depuis 25 ans !");
                    }
                    lireEntier("Depuis combien d'années êtes-vous assuré chez nous ?", out nbrAnneesAnciennete);
                    Console.ResetColor();
                } 
                

                //traitement
                CalculeContrat(agePersonne, DureeObtentionPermis, nbrAccident, nbrAnneesAnciennete, out message);

                //affichage du résultat
                if (message == "Refus")
                {
                    message = "Désolé, nous ne pouvons pas vous assurer.";
                }
                else
                {
                    message = "Nous vous attribuons le contrat de type " + message;
                }
                
                Console.WriteLine($"\n{message}\n");

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'espace' = oui, autre = non ");
                reapeatProg = Console.ReadLine();
                
            } while (reapeatProg == " ");
        }
        /// <summary>
        /// Déterminer le tarif attribué à un candidat à l'assurance
        /// </summary>
        /// <param name="age">age de la personne  non nul et >=18</param>
        /// <param name="perDep">temps écoulé depuis l'obtention du permis non nul >=0</param>
        /// <param name="nbrAcc"> Nombre d’accidents déjà eu non nul et >=0</param>
        /// <param name="mess">type de contrat</param>
        static void CalculeContrat(uint age, uint obtenuPermis, uint nbAccident, uint nbAnneeAnciennete, out string contrat)
        {
            if (age < 25 && obtenuPermis < 2)
            {
                if (nbAccident == 0)
                {
                    contrat = "Rouge";
                }
                else
                {
                    contrat = "Refus";
                }
            }

            else if ((age < 25 && obtenuPermis >= 2) || (age >= 25 && obtenuPermis < 2))
            {
                if (nbAccident == 0)
                {
                    contrat = "Orange";
                }
                else if (nbAccident == 1)
                {
                    contrat = "Rouge";
                }
                else
                {
                    contrat = "Refus";
                }
            } 
            else
            {
                if (nbAccident == 0)
                {
                    contrat = "Vert";
                }
                else if (nbAccident == 1)
                {
                    contrat = "Orange";
                }
                else if (nbAccident == 2)
                {
                    contrat = "Rouge";
                }
                else
                {
                    contrat = "Refus";
                }
            }
            if (nbAnneeAnciennete > 5)
            {
                // écriture façon if ; else
                if (contrat == "Rouge")
                {
                    contrat = "Orange";
                }
                else if (contrat == "Orange")
                {
                    contrat = "Vert";
                }
                else if (contrat == "Vert")
                {
                    contrat = "Bleu";
                }
                //écriture avec un switch
                //switch (contrat)
                //{
                //    case "Rouge":
                //        contrat = "Orange";
                //        break;
                //    case "Orange":
                //        contrat = "Vert";
                //        break;
                //    case "Vert":
                //        contrat = "Bleu";
                //        break;
                //    default:
                //        break;
                //}
            }
        }
        static void lireEntier(string question, out uint n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!uint.TryParse(nUser, out n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La réponse encodée n'est pas valide, veuillez encoder une valeur entière !");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
            Console.ResetColor();
        }
    }
}