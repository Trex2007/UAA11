using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _5TI_Tri2024_AdrienBrahy
{
    public struct methodeProjet
    {
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
        /// generer un nombre aleatoire
        /// </summary>
        /// <param name="min">nombre min</param>
        /// <param name="max">nombre max</param>
        /// <returns></returns>
        public int aleNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max + 1);
        }
        /// <summary>
        /// trier un tableau par ordre croissant avec la methode shell 
        /// </summary>
        /// <param name="tab">tableau rempli avec des int</param>
        /// <returns></returns>
        public int[] triShell(int[] tab)
        {
            int ecart = tab.Length;
            bool swp;
            int swap;
            do
            {
                ecart /= 2;
                do
                {
                    swp = false;
                    for (int i = 0; i < tab.Length - ecart; i++)
                    {
                        if (tab[i] > tab[i + ecart])
                        {
                            swp = true;
                            swap = tab[i];
                            tab[i] = tab[i + ecart];
                            tab[i + ecart] = swap;
                        }
                    }
                } while (swp);
            } while (ecart != 1);
            return tab;
        }

        public int[] triBulle(int[] tab)
        {
            bool b1 = true;
            int az;
            while (b1)
            {
                b1 = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        az = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = az;
                        b1 = true;
                    }
                }
            }
            return tab;
        }
        public int[] triIntuitif(int[] tab)
        {
            int echange;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        echange = tab[i];
                        tab[i] = tab[j];
                        tab[j] = echange;
                    }
                }
            }
            return tab;
        }
        public int[] triEncastrement(int[] tab)
        {
            int n = tab.Length;
            for (int j = 1; j < n; j++)
            {
                int x = tab[j];
                int i = j - 1;
                bool bpp = false;
                while (x < tab[i] && !bpp)
                {
                    tab[i + 1] = tab[i];
                    if (i == 0)
                    {
                        bpp = true;
                    }
                    else
                    {
                        i = i - 1;
                    }
                }
                if (bpp)
                {
                    tab[0] = x;
                }
                else
                {
                    tab[i + 1] = x;
                }
            }
            return tab;
        }
        public int[] triSelect(int[] TableauRandom)
        {
            int replaceValue;
            int replaceIndex;
            for (int i = 0; i <= TableauRandom.Length - 2; i++)
            {
                replaceIndex = i;
                replaceValue = TableauRandom[i];
                for (int checkIndex = i + 1; checkIndex <= TableauRandom.Length - 1; checkIndex++)
                {
                    if (TableauRandom[checkIndex] < replaceValue)
                    {
                        replaceValue = TableauRandom[checkIndex];
                        replaceIndex = checkIndex;
                    }
                }
                if (replaceIndex != i)
                {
                    TableauRandom[replaceIndex] = TableauRandom[i];
                    TableauRandom[i] = replaceValue;
                }
            }
            return TableauRandom;
        }
        public string showTabInt(int[] tab)
        {
            string mess = "";
            for (int i = 0; i < tab.Length; i++)
            {
                mess += tab[i];
                mess += "; ";
            }
            return mess;
        }
        public int[] tabPub(int[] tabP)
        {
            int[] tab = new int[tabP.Length];
            for (int i = 0; i < tabP.Length;i++)
            {
                tab[i] = tabP[i];
            }
            return tab;
        }
    }
}