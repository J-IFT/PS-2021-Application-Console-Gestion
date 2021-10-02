using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys
{
    class FonctionsMatieres
    {
        public static Matieres CreerMatiere()
        {
            Matieres p = new Matieres();

            // demander du nom
            p.Nom = FonctionsUtilisateurs.DemandeString("Quel est le nom de la matière ?");

            // demander le code de la matière
            p.Code = FonctionsUtilisateurs.DemandeEntier("Quel est le code de la matière ?", "code");

            // demander le nombre d'heures de la matière
            p.Nbheures = FonctionsUtilisateurs.DemandeEntier("Quel est le nombre d'heures de la matière ?", "heure");

            return p;

        }
    }
}
