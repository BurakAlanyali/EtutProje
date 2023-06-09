using EtutProje.Entity.Classes.BaseClasses;
using EtutProje.Entity.Classes.SektorClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.Entity.Classes.FirmaClasses
{
    public class Firma : BaseObject
    {
        public string FirmaKodu { get; set; }
        public string FirmaAdi { get; set; }
        public int SektorId { get; set; }
        public Sektor Sektor { get; set; }
    }
}
