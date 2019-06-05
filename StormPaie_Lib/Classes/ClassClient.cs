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

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
