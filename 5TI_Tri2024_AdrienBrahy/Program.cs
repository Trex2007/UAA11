using System;
using System.Diagnostics;
using System.Threading.Channels;

namespace _5TI_Tri2024_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            methodeProjet outilPro = new methodeProjet(); // isntanciation d ela structure
            int taille; //nombre de chiffre que l'utilisateur veut            
            int tri; //choisir les tris
            string reapeatProg; // information d'utilisateur pour la reprise du programme
            Stopwatch chrono = new Stopwatch(); // définition de l’objet 
            long millisec; // variable pour stocker le tps
            do // boucle de reprise du programe
            {

                // lecture des donnée
                outilPro.lireInt("Combien de valeurs désirez-vous ?", out taille);
                int[] tabP = new int[taille];
                for (int i = 0; i < tabP.Length; i++)
                {
                    tabP[i] = outilPro.aleNumber(0, 1000);
                }
                do
                {
                    outilPro.lireInt("Quelle méthode de tri voulez-vous ? \n 1 - Tri Bulle \n 2 - Tri Encastrement \n 3 - Tri Intuitif \n 4 - Tri Selection \n 5 - Tri Shell\n 6 - Comparaison de temps", out tri);
                    if (tri < 0 && tri > 7)
                    {
                        Console.WriteLine("La méthode choisie n'es pas bonne. Recommencé.");
                    }
                } while (tri < 0 && tri > 7);

                //traitement
                if (tri == 1)
                {
                    Console.WriteLine(outilPro.showTabInt(outilPro.triBulle(tabP)));
                }
                else if (tri == 2)
                {
                    Console.WriteLine(outilPro.showTabInt(outilPro.triEncastrement(tabP)));
                }
                else if (tri == 3)
                {
                    Console.WriteLine(outilPro.showTabInt(outilPro.triIntuitif(tabP)));
                }
                else if (tri == 4)
                {
                    Console.WriteLine(outilPro.showTabInt(outilPro.triSelect(tabP)));
                }
                else if (tri == 5)
                {
                    Console.WriteLine(outilPro.showTabInt(outilPro.triShell(tabP)));
                }
                else
                {
                    chrono = Stopwatch.StartNew(); // démarrage chronomètre
                    outilPro.triBulle(outilPro.tabPub(tabP));
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;// récupération du temps écoulé
                    Console.WriteLine("La méthode bulle a pris : " + $"{millisec} millisecondes");// affichage du temps écoulé
                    
                    chrono = Stopwatch.StartNew(); // démarrage chronomètre
                    outilPro.triEncastrement(outilPro.tabPub(tabP));
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;// récupération du temps écoulé
                    Console.WriteLine("La méthode Encastrement a pris : " + $"{millisec} millisecondes");// affichage du temps écoulé

                    chrono = Stopwatch.StartNew(); // démarrage chronomètre
                    outilPro.triIntuitif(outilPro.tabPub(tabP));
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;// récupération du temps écoulé
                    Console.WriteLine("La méthode Intuitive a pris : " + $"{millisec} millisecondes");// affichage du temps écoulé

                    chrono = Stopwatch.StartNew(); // démarrage chronomètre
                    outilPro.triSelect(outilPro.tabPub(tabP));
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;// récupération du temps écoulé
                    Console.WriteLine("La méthode selective a pris : " + $"{millisec} millisecondes");// affichage du temps écoulé

                    chrono = Stopwatch.StartNew(); // démarrage chronomètre
                    outilPro.triShell(outilPro.tabPub(tabP));
                    chrono.Stop();
                    millisec = chrono.ElapsedMilliseconds;// récupération du temps écoulé
                    Console.WriteLine("La méthode shell a pris : " + $"{millisec} millisecondes");// affichage du temps écoulé
                }

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