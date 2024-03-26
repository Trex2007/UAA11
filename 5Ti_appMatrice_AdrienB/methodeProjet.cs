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
        public void askSize(ref int mN, out int lignesT, out int colonnesT)
        {
            mN = mN + 1;
            lignesT = 0;
            colonnesT = 0;
            Console.WriteLine("\nMatrices " + mN + " :");
            while (lignesT < 1 || colonnesT < 1)
            {
                lireInt("Combien de lignes désirez-vous ?", out lignesT);
                lireInt("\nCombien de colones désirez-vous ?", out colonnesT);
                if (lignesT < 1 || colonnesT < 1)
                {
                    Console.WriteLine("\nles dimentions ne sont pas bonne, merci de mettre minimum 1");
                }
            }
        }
        public void matricesAI(int lignesT, int colonnesT, out int[,] matrices)
        {
            matrices = new int[lignesT,colonnesT];
            Random alea = new Random();
            for (int i = 0; i < lignesT; i++) { 
                for (int j = 0; j < colonnesT; j++)
                {
                    matrices[i, j] = alea.Next(0,10);
                }
            }
        }
        public void matrAdd(int[,]  matriceOne, int[,]  matriceTwo, out int[,]  matriceRes)
        {
            matriceRes = new int[matriceOne.GetLength(0),matriceOne.GetLength(1)];
            if (matriceOne.GetLength(0) == matriceTwo.GetLength(0) && matriceOne.GetLength(1) == matriceTwo.GetLength(1))
            {
                for (int i = 0; i < matriceOne.GetLength(0); i++)
                {
                    for (int j = 0; j < matriceOne.GetLength(1); j++)
                    {
                        matriceRes[i, j] = matriceOne[i, j] + matriceTwo[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("L'addition n'est pas possible");
            }
            
        }
        public void matrMult(int[,]  matriceOne, int[,]  matriceTwo, out int[,] matriceRes)
        {
            matriceRes = null;
        }
        public void matrConc(int[,] matriceRes, out string mess)
        {
            mess = null;
            for (int i = 0; i < matriceRes.GetLength(0); i++)
            {
                for (int j = 0; j < matriceRes.GetLength(1); j++)
                {
                    mess = mess + matriceRes[i, j] + " | ";
                }
                mess = mess + "\n";
            }
        }
    }
}
