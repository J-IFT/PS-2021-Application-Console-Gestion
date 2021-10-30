using ProjetJulietteJeremyMailys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys.Services
{
    public class FonctionsFormations
    {
        public List<Formations> _lesFormations = new List<Formations>();

        private FonctionsUtilisateurs foncUtilisateurs;
        public FonctionsFormations(FonctionsUtilisateurs foncUtilisateurs)
        {
            this.foncUtilisateurs = foncUtilisateurs;
        }

        public virtual Formations CreerFormation()
        {
            Formations f = new Formations();

            // demander du nom
            f.Nom = foncUtilisateurs.DemandeString("Quel est le nom de la formation ?");

            // demander le code de la matière
            f.Code = foncUtilisateurs.DemandeString("Quel est le code de la formation ?", "code");

            // demander le nombre d'heures de la matière
            f.Niveau = foncUtilisateurs.DemandeString("Quel est le niveau de la formation ?");

            _lesFormations.Add(f);

            return f;

        }

        public virtual Formations demandeFormation()
        {
            while (true)
            {
                int codeFormation = foncUtilisateurs.DemandeString("Quel est le code de la formation ?", "code");
                foreach(var f in _lesFormations)
                {
                    if (f.Code == codeFormation)
                    {
                        return f;
                    }
                }
            }
        }

        public virtual string afficherFormation(int code)
        {
            string nomForma = "";

            foreach (var f in _lesFormations)
            {
                if (f.Code == code)
                {
                    nomForma = f.Nom;
                }
            }

            return nomForma;
        }
    }
}
