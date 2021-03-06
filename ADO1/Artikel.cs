﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class Artikel
    {
        public int ArtikelOid {get;set;}
        public String ArtikelNr { get; set; }
        public int ArtielGruppe { get; set; }
        public String Bezeichnung { get; set; }
        public Int32 Bestand { get; set; }
        public Int16 Meldebestand { get; set; }
        public int Verpackung { get; set; }
        public Decimal VkPreis { get; set; }
        public DateTime LetzteEntnahme { get; set; }
        public override string ToString()
        {
            return this.ArtikelNr.ToString() + ": " + this.Bezeichnung;
        }
    }
}
