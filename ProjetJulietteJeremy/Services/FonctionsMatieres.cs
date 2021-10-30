using ProjetJulietteJeremyMailys.Model;
using ProjetJulietteJeremyMailys.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys
{
    public class FonctionsMatieres
    {

        private FonctionsUtilisateurs foncUtilisateur;
        private FonctionsFormations foncFormations;
        public FonctionsMatieres(FonctionsUtilisateurs foncUtilisateur, FonctionsFormations foncFormations)
        {
            this.foncUtilisateur = foncUtilisateur;
            this.foncFormations = foncFormations;
        }
        public Matieres CreerMatiere()
        {
            Matieres p = new Matieres();

            // demander du nom
            p.Nom = foncUtilisateur.DemandeString("Quel est le nom de la matière ?");

            // demander le code de la matière
            p.Code = foncUtilisateur.DemandeString("Quel est le code de la matière ?", "code");

            // demander le nombre d'heures de la matière
            p.Nbheures = foncUtilisateur.DemandeString("Quel est le nombre d'heures de la matière ?", "heure");

            // Demander le nom de la formation à laquelle ratacher la matière
            p.CodeFormation = foncFormations.demandeFormation().Code;

            return p;

        }
    }
}
