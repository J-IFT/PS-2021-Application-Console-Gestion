using ProjetJulietteJeremyMailys.Model;
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
            p.Code = FonctionsUtilisateurs.DemandeString("Quel est le code de la matière ?", "code");

            // demander le nombre d'heures de la matière
            p.Nbheures = FonctionsUtilisateurs.DemandeString("Quel est le nombre d'heures de la matière ?", "heure");

            return p;

        }
    }
}
