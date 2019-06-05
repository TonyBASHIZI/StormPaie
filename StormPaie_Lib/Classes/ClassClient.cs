using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StormPaie_Lib.Classes
{
    public class Client
    {
        public Client()
        {
        }

        public string Matricule { get; }

        public string IdNFC { get; set; }

        public string Nom { get; set; }

        public string Postnom { get; set; }

        public string Prenom { get; set; }

        public string Sexe { get; set; }

        public string Telephone { get; set; }

        public string Adresse { get; set; }

        public string Affiliation { get; set; }

        public string Reseau { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
