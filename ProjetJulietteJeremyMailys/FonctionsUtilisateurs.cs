using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys
{
    class FonctionsUtilisateurs
    {
        /// <summary>
        /// Demande à l'utilisateur un entier
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int DemandeEntier(string message)
        {
            bool monTexteEstEntier = false;
            int chiffre = 0;

            while (monTexteEstEntier == false)
            {
                Console.WriteLine(message);
                string monTexte = Console.ReadLine();
                monTexteEstEntier = int.TryParse(monTexte, out chiffre);
            }

            return chiffre;
        }

        // Demande à l'utilisateur une chaine de caractère
        public static string DemandeString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }
    }
}
