using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

                if (string.IsNullOrEmpty(monTexte.Trim(' ')))
                {
                    monTexteEstEntier = false;
                    Console.WriteLine("La saisie est vide.");
                    Console.WriteLine();
                }

                else if (chiffre <= 0)
                {
                    monTexteEstEntier = false;
                    Console.WriteLine("Le nombre d'heures doit etre un chiffre ou nombre superieur à 0.");
                    Console.WriteLine();
                }
            }
            return chiffre;
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
                int chiffre;
                if (string.IsNullOrEmpty(monTexte.Trim(' ')))
                    {
                    texteNonNul = true;
                    Console.WriteLine("La saisie est vide.");
                    Console.WriteLine();
                }

                else if (int.TryParse(monTexte, out chiffre))
                {
                    texteNonNul = true;
                    Console.WriteLine("Le nom de la matière ne peut pas etre que des chiffres.");
                    Console.WriteLine();
                }

                else if (!char.IsUpper(monTexte[0]))
                {
                    texteNonNul = true;
                    Console.WriteLine("La matière doit commencer par une majuscule.");
                    Console.WriteLine();
                }

                else
                {
                    texteNonNul = false;
                }

            }

            return monTexte;
        }

        // Fonction qui permet de formater les nombres dans le format 1 234 567 au lieu de 1234567
        public static string FormatNombre(int nb)
        {
            //On défini un nouveau format de nombre qu'on personnalise
            // " " pour un espace en séparateur (a modifier si on veut "," ou ".") dans la variable NumbreGroupSeparator 
            // NumberDecimalDigits sert à afficher ou non quelque chose après la virgule (1 000.00), à 0 on n'affiche pas la virgule et les décimaux derrière
            NumberFormatInfo nfi = new NumberFormatInfo { NumberGroupSeparator = " ", NumberDecimalDigits = 0 };

            // on retourne notre nombre transformé en string en surchargeant la méthode de notre Format personnalisé
            return nb.ToString("n", nfi);
        }
    }
}
