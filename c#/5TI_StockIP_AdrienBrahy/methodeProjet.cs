using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _5TI_StockIP_AdrienBrahy
{
    public struct methodeProjet
    {
        public string ConcateneAdresse(int[,] MatrAdresse, string[] tableNom)
        {
            string mess = "";
            for (int j = 0; j < MatrAdresse.GetLength(1); j++)
            {
                for (int i = 0; i < MatrAdresse.GetLength(0); i++)
                {
                    mess += MatrAdresse[i, j];
                    if (i < MatrAdresse.GetLength(1) - 1)
                    {
                        mess += ".";
                    }
                }
                mess += " " + tableNom[j] + "\n";
            }
            return mess;
        }
        public bool AjouteAdresseIP(int place, int[] adresseIP, int[,] MatrAdresse)
        {
            bool adressAdd = false;
            if (place != MatrAdresse.GetLength(0))
            {
                for (int i = 0; i < 4 ; i++)
                {
                    MatrAdresse[place, i] = adresseIP[i]; 
                }
                place = place + 1;
                adressAdd = true;
            }
            return adressAdd;
        }
        public bool AjouteNom(int place,string[] tableNom)
        {
            bool placeNom = false;
            if (place != tableNom.GetLength(place))
            {
                tableNom[place] = lireString("quelle est vôtre nom ?");
                placeNom = true;
            }
            return placeNom;
        }
        public void LireAdresseIP(int[] adresseIP)
        {
            for (int i = 0; i < 4; i++)
            {
                adresseIP[i] = lireOctet("quelle est vôtre " + (i + 1) + " donnée de l'adresse ip");
            }
        }
        public byte lireOctet(string question)
        {
            string nUser;
            byte rep;
            do
            {
                Console.WriteLine(question);
                nUser = Console.ReadLine();
                while (!byte.TryParse(nUser, out rep))
                {
                    Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réaltérer la question.");
                    Console.WriteLine(question);
                    nUser = Console.ReadLine();
                }
                if (rep < 0 || rep > 255)
                {
                    Console.WriteLine("Entrez un nombre entre 0 et 255");
                }
            } while (rep< 0 || rep> 255);
            return rep;
        }
        public string lireString(string question)
        {
            string rep;
            Console.WriteLine(question);
            rep = Console.ReadLine();
            while (rep == "")
            {
                Console.WriteLine("La réponse envoyer n'est pas valide, vueillez réaltérer la question.");
                Console.WriteLine(question);
                rep = Console.ReadLine();
            }
            return rep;
        }
    }
}