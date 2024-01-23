namespace _5t_AdrienB_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Résolution d'un trinome du second degré !");

            double a; //coef du terme du second degré
            double b; //coef du terme du premier degré
            double c; //coef du terme du terme indépendant
            string message; //résultat a afficher
            string reapeatProg; // information d'utilisateur pour la reprise du programme

            do // boucle de reprise du programe
            {
                // lecture des donnée
                Console.WriteLine("Encodez la valeur du coef du second degré");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Encodez la valeur du coef du premier degré");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Encodez la valeur du coef du terme indépendant");
                c = double.Parse(Console.ReadLine());

                //traitement
                ResoudTrinome(a, b, c, out message);

                //afficher le résultat
                Console.WriteLine(message);

                //demande de reprise
                Console.WriteLine("voulez-vous recommencez 'O' = oui, 'N' = non ");
                reapeatProg = Console.ReadLine();

            } while (reapeatProg == "O");
        }
        /// <summary>
        /// resoud le trinôme du second degré ax² +bx+c=0
        /// </summary>
        /// <param name="a"> non vide | coef du terme du second degré </param>
        /// <param name="b"> non vide | coef du terme du premier degré </param>
        /// <param name="c"> non vide | coef du terme du terme indépendant </param>
        /// <param name="message"> résultat a afficher </param>
        static void ResoudTrinome(double a, double b, double c, out string message)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1;
            double x2;
            if (delta > 0)
            {
                x1 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                x2 = ((-b) + Math.Sqrt(delta)) / (2 * a);
                message = "il y a 2 solutions :" + x1 + " et " + x2;
            }
            else if (delta == 0)
            {
                x1 = (-b) / (2 * a);
                message = "il y a 1 solution:" + x1;
            }
            else
            {
                message = "il n'y a pas de solution";
            }
        }
    }
}