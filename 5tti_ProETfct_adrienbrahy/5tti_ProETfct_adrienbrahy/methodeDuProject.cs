using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5tti_ProETfct_adrienbrahy
{
    public struct methodeDuProject
    {
        /// <summary>
        /// dit que ce n'est pas bon si il y a des fautes d'orthographes
        /// </summary>
        /// <param name="question"></param>
        /// <param name="n"></param>
        public void lireInt(string question, out int n)
        {
            string nUser;
            Console.WriteLine(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("- - - - - - - -");
                Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réaltérer la question.");
                Console.WriteLine("- - - - - - - -");
                Console.WriteLine(question);
                nUser = Console.ReadLine();
            }
        }
        /// <summary>
        /// génère un nombre aléatoire
        /// </summary>
        /// <returns></returns>
        public int nbrRandom()
        {
            Random aleatoire = new Random();
            int al = aleatoire.Next(1, 7); // Génère un entier compris entre 1 et 6
            return al;
        }
        /// <summary>
        /// met les nombre aléatoir edans un tableau
        /// </summary>
        /// <param name="taille"></param>
        /// <param name="Tal"></param>
        public void TblAl(int taille, out int[] Tal)
        {
            Tal = new int[taille];
            for (int i = 0; i < Tal.Length; i++)
            {
                Tal[i] = nbrRandom();
            }
        }
        /// <summary>
        /// met les nombre un un message un apres l'autre
        /// </summary>
        /// <param name="Tal"></param>
        /// <returns></returns>
        public string conc(int[] Tal)
        {
            string mess="";
            for (int i = 0; i < Tal.Length;i++)
            {
                mess = mess +Tal[i] + " ";
            }
            return mess;
        }
    }
}
