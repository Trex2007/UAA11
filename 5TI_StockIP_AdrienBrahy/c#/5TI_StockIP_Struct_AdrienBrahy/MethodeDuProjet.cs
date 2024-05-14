using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TI_StockIP_Struct_AdrienBrahy
{
    public struct MethodesDuProjet
    {
        /// <summary>
        /// saisir et de valider une valeur d’octet au clavier
        /// </summary>
        /// <returns> nombre entier compris entre 0 et 255 </returns>
        public uint LireOctet()
        {
            uint octet;
            string userOctet;
            do
            {
                Console.WriteLine("Encodez un entier compris entre 0 et 255");
                userOctet = Console.ReadLine();
                while (!uint.TryParse(userOctet, out octet))
                {
                    Console.WriteLine("Donnée incorrecte !");
                    Console.WriteLine("Encodez un entier compris entre 0 et 255");
                    userOctet = Console.ReadLine();
                }

            } while (octet < 0 || octet > 255);
            return octet;
        }
        /// <summary>
        /// Lire 4 valeurs entières comprises entre 0 et 255 et les stocker dans un tableau de 4 places tabAdresse       
        /// </summary>
        /// <param name="tabAdresse">Adresse IP à rentrer</param>
        public void LireAdresseIP(out uint[] tabAdresse)
        {
            tabAdresse = new uint[4];
            for (int i = 0; i < 4; i++)
            {
                tabAdresse[i] = LireOctet();
            }
        }
        /// <summary>
        /// Ajouter le contenu de ip dans tabAdresses à la place nbAdresses si tabAdresses n’est pas pleine. 
        /// renvoyer vrai si ajout réalisé, faux, sinon.
        /// </summary>
        /// <param name="adresse">ip à ajouter au tableau</param>
        /// <param name="nom">les noms</param>
        /// <param name="nbAdresses">première place disponible dans la matrice des adresses (vaut le nombre de lignes de tabAdresses  si la matrice est pleine)</param>
        /// <param name="tabAdresses">Matrice contenant toute les adresses IP</param>
        public bool AjouteAdresseIP(uint[] adresse, string nom, ref uint nbAdresses, ref Adresse[] tabAdresses)
        {
            bool ok = true;

            if (nbAdresses < tabAdresses.Length)
            {
                tabAdresses[nbAdresses].nom = nom;
                for (int i = 0; i < 4; i++)
                {
                    tabAdresses[nbAdresses].adresseIP[i] = adresse[i];
                }
                nbAdresses += 1;
            }
            else
            {
                ok = false;
            }
            return ok;
        }
        /// <summary>
        /// Renvoyer une chaîne de caractères contenant l’adresse IP se trouvant à la ligne numéro ‘ligne’ 
        /// du tableau des adresses. Chaque octet est séparé de l’octet suivant par un point.
        /// </summary>
        /// <param name="tabAdresses">matrice de toutes les adresses</param>
        /// <param name="ligne">numéro de la ligne contenant l’adresse à concaténer</param>
        /// <returns>chaîne de caractères contenant l’adresse IP se trouvant à la ligne numéro ‘ligne’</returns>
        public string ConcateneAdresse(Adresse[] tabAdresses, int ligne)
        {
            string chaine = "";
            for (int i = 0; i < 4; i++)
            {
                chaine += tabAdresses[ligne].adresseIP[i];
                if (i != 3)
                {
                    chaine += ".";
                }
            }
            return chaine;
        }
        /// <summary>
        /// Renvoyer une chaîne de caractères contenant l’adresse IP se trouvant à la ligne numéro ‘ligne’ 
        /// du tableau des adresses. Chaque octet est séparé de l’octet suivant par un point.
        /// </summary>
        /// <param name="tabAdresses">matrice de toutes les adresses</param>
        /// <param name="nbAdresse">numéro de la ligne contenant l’adresse à concaténer</param>
        /// <returns>chaîne de caractères contenant l’adresse IP se trouvant à la ligne numéro ‘ligne’</returns>
        public string ConcateneTout(Adresse[] tabAdresses, uint nbAdresse)
        {
            string chaine = "";
            for (int i = 0; i < nbAdresse; i++)
            {
                chaine += tabAdresses[i].nom + " : " + ConcateneAdresse(tabAdresses, i);
                if (i != 3)
                {
                    chaine += "\n";
                }
            }
            return chaine;
        }
    }
}
