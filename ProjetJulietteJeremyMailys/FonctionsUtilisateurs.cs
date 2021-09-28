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

            //Math.Abs permet de passer les nombres negatifs en positif et éviter d'avoir des heures de cours négatives
            return Math.Abs(chiffre);
        }

        // Demande à l'utilisateur une chaine de caractère
        public static string DemandeString(string message)
        {
            // Declaration des variables
            bool texteNonNul = true;
            string monTexte = "";

            // On boucle tant que texteNonNul est true, quand isNullOrEmpty retourne false (donc que la chaine n'est plus null ou vide), on sort de la boucle et on retourne le texte
            while (texteNonNul)
            {
                Console.WriteLine(message);
                monTexte = Console.ReadLine();
                // IsNullOrEmpty retourne false si la chaine n'est pas vide
                // On enlève les espaces malicieux de la chaine avec Trim() pour éviter de se retrouver avec matière = '     '
                texteNonNul = string.IsNullOrEmpty(monTexte.Trim(' '));
            }

            return monTexte;
        }
    }
}
