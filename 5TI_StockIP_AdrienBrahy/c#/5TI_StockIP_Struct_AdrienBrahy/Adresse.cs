using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TI_StockIP_Struct_AdrienBrahy
{
    public struct Adresse
    {
        public uint[] adresseIP;
        public string nom;

        // Constructeur : préparation du tableau a 4 place et initialisation à 0
        // initialiastion du nom au vide

        public Adresse()
        {
            adresseIP = new uint[4];
            for (int i = 0; i < adresseIP.Length; i++)
            {
                adresseIP[i] = 0;
            }
            nom = "";
        }
    }
}
