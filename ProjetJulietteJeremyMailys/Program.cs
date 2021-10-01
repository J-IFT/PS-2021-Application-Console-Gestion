using System;
using System.Collections.Generic;

namespace ProjetJulietteJeremyMailys
{
    class Program
    {
        static void Main(string[] args)
        {

            // Faire la liste
            List<Matieres> lesMatieres = new List<Matieres>();

            // Faire le menu
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Bonjour ! :) Que voulez vous faire ?");
                Console.WriteLine("1. Créer une nouvelle matière");
                Console.WriteLine("2. Afficher l'ensemble des matières");
                Console.WriteLine("3. Afficher le nombre total d'heures");
                Console.WriteLine("4. Quitter");
                string choixUtilisateur = Console.ReadLine();
                if (choixUtilisateur == "1")
                {
                    Matieres p1 = FonctionsMatieres.CreerMatiere();
                    lesMatieres.Add(p1);
                    //première question à régler (quand on met rien ça compte quand même)
                }
                else if (choixUtilisateur == "2")
                {
                    Console.WriteLine("*********************************");
                    foreach (Matieres p in lesMatieres)
                    {
                        //affichage
                        Console.WriteLine("Matière : " + p.Nom + "\nCode : " + p.Code + ", Nombres d'heures : " + p.Nbheures);
                        Console.WriteLine("*********************************");
                    }
                }
                else if (choixUtilisateur == "3")
                {
                    foreach (Matieres p in lesMatieres)
                    {
                        //affichage
                        Console.WriteLine("Nombres d'heures : " + p.NbTotalheures);
                        Console.WriteLine("*********************************");
                    }
                }
                else if (choixUtilisateur == "4")
                {
                    exit = true;
                    Console.WriteLine("Appuyer sur une touche pour quitter");
                    Console.ReadKey();
                }
            }
        }
    }
}
