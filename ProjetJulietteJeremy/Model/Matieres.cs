using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetJulietteJeremyMailys.Model
{
    public class Matieres
    {
        public string Nom;

        public int Code;

        public int Nbheures;

        public int CodeFormation;

        public string NbTotalheures { get; internal set; }
    }
}
