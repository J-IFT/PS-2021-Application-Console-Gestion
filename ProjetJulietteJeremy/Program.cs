using ProjetJulietteJeremyMailys.Model;
using ProjetJulietteJeremyMailys.Services;
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
            List<Formations> lesFormations = new List<Formations>();

            FonctionsUtilisateurs foncUtilisateurs = new FonctionsUtilisateurs();
            FonctionsFormations foncFormations = new FonctionsFormations(foncUtilisateurs);
            FonctionsMatieres foncMatieres = new FonctionsMatieres(foncUtilisateurs, foncFormations);


            // Faire le menu
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Bonjour ! :) Que voulez vous faire ?");
                Console.WriteLine("1. Créer une nouvelle matière");
                Console.WriteLine("2. Afficher l'ensemble des matières");
                Console.WriteLine("3. Afficher le nombre total d'heures");
                Console.WriteLine("4. Créer une nouvelle formation");
                Console.WriteLine("5. Afficher les informations des formations");
                Console.WriteLine("6. Quitter");
                string choixUtilisateur = Console.ReadLine();
                if (choixUtilisateur == "1")
                {
                    if (lesFormations.Count == 0)
                    {
                        Console.WriteLine("Créer d'abord une formation avant d'ajouter une matière");
                        Console.WriteLine("*********************************");
                    }
                    else
                    {
                        Matieres p1 = foncMatieres.CreerMatiere();
                        lesMatieres.Add(p1);
                    }
                }
                else if (choixUtilisateur == "2")
                {
                    Console.WriteLine("*********************************");
                    foreach (Matieres p in lesMatieres)
                    {
                        //affichage
                        Console.WriteLine("Matière : " + p.Nom + "\nCode : " + p.Code + ", Nombres d'heures : " + FonctionsUtilisateurs.FormatNombre(p.Nbheures) + "Formation : " + foncFormations.afficherFormation(p.CodeFormation));
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
                if (choixUtilisateur == "4")
                {
                    Formations f1 = foncFormations.CreerFormation();
                    lesFormations.Add(f1);
                }
                else if (choixUtilisateur == "5")
                {
                    Console.WriteLine("*********************************");
                    foreach (Formations f in lesFormations)
                    {
                        //affichage
                        Console.WriteLine("Formation : " + f.Nom + "\nCode : " + f.Code + ", Niveau de la formation : " + f.Niveau) ;
                        Console.WriteLine("*********************************");
                    }
                }
                else if (choixUtilisateur == "6")
                {
                    exit = true;
                    Console.WriteLine("Appuyer sur une touche pour quitter");
                    Console.ReadKey();
                }
            }
        }
    }
}
