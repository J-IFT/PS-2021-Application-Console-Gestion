using ProjetJulietteJeremyMailys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys.Services
{
    class FonctionsFormations
    {
        public static Formations CreerFormation()
        {
            Formations f = new Formations();

            // demander du nom
            f.Nom = FonctionsUtilisateurs.DemandeString("Quel est le nom de la formation ?");

            // demander le code de la matière
            f.Code = FonctionsUtilisateurs.DemandeString("Quel est le code de la formation ?", "code");

            // demander le nombre d'heures de la matière
            f.Niveau = FonctionsUtilisateurs.DemandeString("Quel est le niveau de la formation ?");

            return f;

        }
    }
}
