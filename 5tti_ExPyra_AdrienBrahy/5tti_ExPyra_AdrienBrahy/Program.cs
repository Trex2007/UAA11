using System.Threading.Tasks.Dataflow;

namespace tti_exSpec_AdrienBrahy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mess; // message
            string reapeatProg; // boucle pour relancer
            double forme; // type de forme en xo

            do
            {
                // lecture des donnée
                lireDouble("carré X = 1 | carré XO = 2 | carré OX = 3 | triangle = 4", out forme);

                //traitement
                if (forme == 1)
                {
                    carrX(out mess);
                    Console.WriteLine("- - - - - - - -");
                }
                else if (forme == 2)
                {
                    carrXO(out mess);
                    Console.WriteLine("- - - - - - - -");
                }
                else if (forme == 3)
                {
                    carrOX(out mess);
                    Console.WriteLine("- - - - - - - -");
                }
                else
                {
                    tria(out mess);
                    Console.WriteLine("- - - - - - - -");
                }

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
        /// fait un carré de x
        /// </summary>
        /// <param name="mess"></param>
        static void carrX(out string mess)
        {
            mess = "";
            int m = 4;
            for (int l = 1; l <= m; l++)
            {
                for (int c = 1; c <= m; c++)
                { 
                    mess += "X";
                }
                mess += "\n";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mess"></param>
        static void carrXO(out string mess)
        {
            mess = "\n Not Found \n";
        }
        /// <summary>
        /// fait un carré de X avec uyn diago O
        /// </summary>
        /// <param name="mess"></param>
        static void carrOX(out string mess)
        {
            mess = "";
            int m = 4;
            for (int l = 1; l <= m ; l++)
            {
                for (int c = 1; c <= m ; c++)
                {
                    if (c == m - l + 1)
                    {
                        mess += "O";
                    }
                    else
                    {
                        mess += "X";
                    }
                }
                mess += "\n";
            }
        }
        /// <summary>
        /// Fait un triangle de X & O
        /// </summary>
        /// <param name="mess"></param>
        static void tria(out string mess)
        {
            mess = "";
            int m = 4;
            for (int l = 1; l <= m; l++)
            {
                for (int c = 1; c <= 2*m-1 ; c++)
                {
                    if ((c < m - (l-1)) || (c > m + (l-1)))
                    {
                        mess += "O";
                    }
                    else
                    {
                        mess += "X";
                    }
                }
                mess += "\n";
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
