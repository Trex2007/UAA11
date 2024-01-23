using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt;
            string mess;
            string reapeatProg;

            do // boucle de reprise du programe
            {
                // lecture des donnée

                Console.WriteLine("Entrez vôtre texte a transformer ? \n");
                txt = Console.ReadLine();

                //traitement
                trans(txt, out mess);
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
        /// <summary>
        /// module pour transformer le texte
        /// </summary>
        /// <param name="txt">texte de base</param>
        /// <param name="mess">texte modifiler</param>
        static void trans(string txt, out string mess)
        {
            int codeA; 
            mess = "";
            for (int i = 0; i < txt.Length; i++)
            {
                codeA = (int)txt[i];
                if (codeA < 91 && codeA > 64)
                {
                    codeA += 2;
                    if (codeA > 90)
                    {
                        codeA = -25;
                    }
                }
                else if (codeA < 123 && codeA > 96)
                {
                    codeA += 2;
                    if (codeA > 122)
                    {
                        codeA = -25;
                    }
                }
                else if (codeA < 58 && codeA > 47)
                {
                    codeA = (10 - (codeA - 48)) + 48;
                }
                else if (codeA == 32)
                {
                    codeA = (int)'+';
                }
                mess += Convert.ToChar(codeA);
            }
        }
    }
}
