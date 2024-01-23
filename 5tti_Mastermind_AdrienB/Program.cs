using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille; //demander la taille
            int nBP; //nombres de bonne réponses
            int nMP; //nombres de mauvaise réponses
            int essaie; //calcul de tentatives
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            Console.ResetColor();
            Console.WriteLine(
                "\r███╗░░░███╗░█████╗░░██████╗████████╗███████╗██████╗░  ███╗░░░███╗██╗███╗░░██╗██████╗░\r" +
                "\n████╗░████║██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗  ████╗░████║██║████╗░██║██╔══██╗\r" +
                "\n██╔████╔██║███████║╚█████╗░░░░██║░░░█████╗░░██████╔╝  ██╔████╔██║██║██╔██╗██║██║░░██║\r" +
                "\n██║╚██╔╝██║██╔══██║░╚═══██╗░░░██║░░░██╔══╝░░██╔══██╗  ██║╚██╔╝██║██║██║╚████║██║░░██║\r" +
                "\n██║░╚═╝░██║██║░░██║██████╔╝░░░██║░░░███████╗██║░░██║  ██║░╚═╝░██║██║██║░╚███║██████╔╝\r" +
                "\n╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝  ╚═╝░░░░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░\n");
            do // boucle de reprise du programe
            {

                char[] listColor = { 'R', 'V', 'B', 'J', 'M', 'O' };

                lireDouble("Quelle seras la taille de vôtre Master Mind ? \n", out taille);

                char[] codeColeur = new char[taille];

                choseCode(taille, listColor, out codeColeur);

                essaie = taille *2;

                Console.WriteLine("\nPour ce Master Mind vous aurez droit à "+essaie+" tentatives; Prêt ? GO! \n");

                char[] rep = new char[taille];

                while (essaie > 0){
                    getRep(taille, listColor, out rep);
                    verifBP(taille, rep, codeColeur, out nBP);
                    verifMP(rep, listColor, nBP, codeColeur, out nMP);
                    if(nBP == taille)
                    {
                        Console.WriteLine("Bien joué !");
                        essaie = 0;
                    } else
                    {
                        essaie -= 1;
                        Console.WriteLine("Pas de chance\nIl ne vous reste plus que " + essaie + " Tentatives Reprenez-vous !\n");
                        Console.WriteLine("Vous avez :" + nBP + " pion(s) bien placé et " + nMP + " pion(s) mal placé.");
                    }
                }

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui, 'N' = non ");
                reapeatProg = Console.ReadLine();
                if (reapeatProg == "O")
                {
                    Console.WriteLine("- - - - - - - -");
                }
            } while (reapeatProg == "O");
        }
        static void choseCode(int taille, char[] listColor, out char[] codeCouleur)
        {
            codeCouleur = new char[taille];

            Random rand = new Random();

            int nombreDeLettres = taille;
            Console.Write("Lettres aléatoires générées : ");
            for (int i = 0; i < nombreDeLettres; i++)
            {
                int indexAleatoire = rand.Next(0, listColor.Length);
                char couleurAleatoire = listColor[indexAleatoire];
                codeCouleur[i] = couleurAleatoire;
                Console.Write(couleurAleatoire + " ");
            }
        }
        static void getRep(int taille, char[] listcolor, out char[] rep)
        {
            char a;
            rep = new char[taille];
            for (int i = 0; i < taille; i++)
            {
                do
                {
                    Console.WriteLine("Quelle sera vôtre " + (i + 1) +" couleur ?\nVueillez répondre par R, O, J, V, B, M.\n");
                    a = char.Parse(Console.ReadLine());

                    verifRep(a,listcolor);

                } while (verifRep(a,listcolor) != true);
                rep[i] = a;
            }
            
        }
        static bool verifRep(char a, char[] listcolor)
        {
            if (listcolor.Contains(a))
            {
                return true;
            } else
            {
                return false;
            }
        }
        static void verifBP(int taille, char[] rep, char[]  codeColeur, out int nBP)
        {
            nBP = 0;
            for (int i = 0;i < taille;i++)
            {
                if (rep[i] == codeColeur[i])
                {
                    nBP++;
                }
            }
        }
        static void verifMP(char[] rep, char[] listColor, int nBP, char[] codeColeur, out int nMP)
        {
            nMP = 0;
            
            foreach (char color in listColor)
            {
                if (rep.Count(x => x == color) < codeColeur.Count(x => x == color))
                {
                    nMP += rep.Count(x => x == color);
                } else
                {
                    nMP += codeColeur.Count(x => x == color);
                }
            }
            nMP -= nBP;
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
                Console.ResetColor();
                nUser = Console.ReadLine();
            }
        }
    }
}