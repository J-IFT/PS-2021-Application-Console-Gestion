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
                }
                else if (choixUtilisateur == "2")
                {
                    Console.WriteLine("*********************************");
                    foreach (Matieres p in lesMatieres)
                    {
                        //affichage
                        Console.WriteLine("Matière : " + p.Nom + "\nCode : " + p.Code + ", Nombres d'heures : " + FonctionsUtilisateurs.FormatNombre(p.Nbheures));
                        Console.WriteLine("*********************************");
                    }
                }
                else if (choixUtilisateur == "3")
                {
                    int NbTotalHeures = 0;
                    foreach (Matieres p in lesMatieres)
                    {
                        NbTotalHeures += p.Nbheures;
                    }
                    //affichage
                    Console.WriteLine("Nombres d'heures total : " + FonctionsUtilisateurs.FormatNombre(NbTotalHeures));
                    Console.WriteLine("*********************************");
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
