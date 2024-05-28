using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _5Ti_PrepaExam_AdrienBrahy
{
    public struct methodeProject
    {
        /// <summary>
        /// retire les espaces
        /// </summary>
        /// <param name="chaine"></param>
        /// <returns></returns>
        public string RetireEspaces(string chaine)
        {
            string chaineSSEsp = "";
            int lg =  chaine.Length;
            for (int i = 0; i < lg; i++)
            {
                if (chaine[i] != ' ')
                {
                    chaineSSEsp += chaine[i];
                }
            }
            return chaineSSEsp;
        }
        /// <summary>
        /// cree la 1er matrice
        /// </summary>
        /// <param name="cle"></param>
        /// <param name="texte"></param>
        /// <param name="matrice"></param>
        public void CreeMat(string cle, string texte, out char[,] matrice)
        {
            int d1 = (texte.Length / cle.Length) + 2;
            int d2 = cle.Length;
            if (texte.Length % cle.Length != 0)
            {
                d1++;
            }
            matrice = new char[d1, d2];
        }
        /// <summary>
        /// ecrit tout dans la 1er matrice
        /// </summary>
        /// <param name="cle"></param>
        /// <param name="texte"></param>
        /// <param name="matrice"></param>
        public void EcritChainesDansMat(string cle, string texte, ref char[,] matrice)
        {
            for (int j = 0;j < matrice.GetLength(1);j++) 
            {
                matrice[0, j] = cle[j];
            }
            int k = 0;
            for (int i = 2 ; i < matrice.GetLength(0);i++)
            {
                int j = 0;
                while ((j < matrice.GetLength(1)) && (k < texte.Length)){
                    matrice[i,j] = texte[k];
                    k++;
                    j++;
                }
            }
        }
        /// <summary>
        /// trie la ligne 1
        /// </summary>
        /// <param name="matrice"></param>
        public void triLigne1(ref char[,] matrice)
        {
            bool permut = true;
            while (permut == true)
            {
                permut = false;
                for (int i = 0; i < matrice.GetLength(1)-1; i++)
                {
                    if (matrice[0,i] > matrice[0, i + 1])
                    {
                        char x = matrice[0,i];
                        matrice[0, i] = matrice[0,i+1];
                        matrice[0, i + 1] = x;
                        permut = true;
                    }
                }
            }
        }
        /// <summary>
        /// cree la 2eme matrice
        /// </summary>
        /// <param name="cle"></param>
        /// <param name="matriceTriee"></param>
        public void CreeMatriceOutil(string cle, out char[,] matriceTriee) { 
            matriceTriee = new char[3,cle.Length];
            for (int i = 0; i < matriceTriee.GetLength(1); i++)
            {
                matriceTriee[0, i] = cle[i];
                matriceTriee[2, i] = (char)0;
            }
            triLigne1(ref matriceTriee);
            for (int i = 0;i < matriceTriee.GetLength(1) ; i++)
            {
                matriceTriee[1,i] = char.Parse((i+1).ToString());
            }
        }
        /// <summary>
        /// recopier lister trier du 2 sur la 1
        /// </summary>
        /// <param name="matrice"></param>
        /// <param name="matriceOutil"></param>
        public void ReporteOrder(ref char[,] matrice, ref char[,] matriceOutil)
        {
            for (int i = 0; i < matrice.GetLength(1); i++)
            {
                bool trouve = false;
                int j = 0;
                while (trouve == false && j < matrice.GetLength(1)) 
                {
                    if (matrice[0, i] == matriceOutil[0, j] && matriceOutil[2, j] != '1')
                    {
                        matrice[1, i] = matriceOutil[1, j];
                        matriceOutil[2, j] = '1';
                        trouve = true; 
                    }
                    j++;
                }
            }
        }
        /// <summary>
        /// crée le texte crypter
        /// </summary>
        /// <param name="matrice"></param>
        /// <returns></returns>
        public string ConstruitCryptage(char[,] matrice)
        {
            int i = 1;
            string chaineCrypt = "";
            while (i <= matrice.GetLength(1))
            {
                bool trouve = false;
                int j  = 0;
                while (trouve == false && j < matrice.GetLength(1))
                {
                    if(char.Parse(i.ToString()) == matrice[1, j])
                    {
                        for (int k = 2; k < matrice.GetLength(0)-1; k++)
                        {
                            chaineCrypt += matrice[k, j];
                        }
                        chaineCrypt += " ";
                        trouve = true;
                        i++;
                    }
                    j++;
                }
            }
            return chaineCrypt;
        }
    }
}