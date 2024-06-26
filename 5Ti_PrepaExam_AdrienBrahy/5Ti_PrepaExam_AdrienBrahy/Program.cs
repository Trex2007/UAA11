﻿using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace _5Ti_PrepaExam_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methodeProject outilProject = new methodeProject(); // instanciation de la structure

            string texte = null;    // string
            string cle = null;      // string plus petit que 10 et plus petit que texte
            string repUser;         // réponse de l'utilisateur

            char[,] matrice;        // matrice de base
            char[,] matriceOutil;   // matrice de transfère

            bool TrueFalse = true;  // verifs pour les tailles
            bool fini = false;      // booléen permettant de quitter la boucle principale en cas d'erreur
            

            // boucle d'encodage des adresses et des noms : tant qu'il y a de la place et que l'utilisateur le désire
            do
            {
                // boucle verif taille
                while (TrueFalse)
                {
                    Console.Clear();
                    Console.WriteLine("Quelle est vôtre phrase a déchiffrer ?");
                    texte = Console.ReadLine();

                    Console.WriteLine("\nEtes-vous sûr ? (entrez oui si c'est bon.)");
                    if (Console.ReadLine() == "oui")
                    {
                        TrueFalse = false;
                    }
                }

                TrueFalse = true;

                // boucle verif taille
                while (TrueFalse)
                {
                    Console.Clear();
                    Console.WriteLine("Quelle est vôtre cle ?");
                    cle = Console.ReadLine();
                    if (cle.Length < texte.Length)
                    {
                        Console.WriteLine("\nEtes-vous sûr ? (entrez oui si c'est bon.)");
                        if (Console.ReadLine() == "oui")
                        {
                            TrueFalse = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("il dois être plus petit de 10 caractères et dois est plus petit que le texte = " + texte.Length);
                    }

                }
                Console.Clear();

                Console.WriteLine("voici la phrase de base : " + texte);

                texte = outilProject.RetireEspaces(texte);
                cle = outilProject.RetireEspaces(cle);

                outilProject.CreeMat(cle, texte, out matrice);

                outilProject.EcritChainesDansMat(cle, texte, ref matrice);

                outilProject.CreeMatriceOutil(cle, out matriceOutil);

                outilProject.ReporteOrder(ref matrice, ref matriceOutil);

                outilProject.ConstruitCryptage(matrice);

                Console.WriteLine("\nVoila la 1er matrice : \n");

                for (int i = 0; i < matrice.GetLength(0); i++)
                {
                    for (int j = 0; j < matrice.GetLength(1); j++)
                    {
                        Console.Write(matrice[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\nVoila la 2er matrice : \n");

                for (int i = 0; i < matriceOutil.GetLength(0); i++)
                {
                    for (int j = 0; j < matriceOutil.GetLength(1); j++)
                    {
                        Console.Write(matriceOutil[i, j] + " ");
                    }
                    Console.Write("\n");
                }
                Console.WriteLine("\nVoici la phrase de cypté : " + outilProject.ConstruitCryptage(matrice))
                    
                    ;
                Console.WriteLine("\nVoulez-vous encoder une autre adresse ? (oui = O, non = autre touche)");
                repUser = Console.ReadLine().ToUpper();
            } while (!fini && repUser == "O");
        }
    }
}