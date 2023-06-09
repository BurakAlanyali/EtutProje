using EtutProje.Entity.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.Entity.Classes.FirmaClasses
{
    public class FirmaYetkili:BaseObject
    {
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        [Display(Name ="Yetkili Ad")]
        public string Ad { get; set; }
        [Display(Name = "Yetkili Soyad")]
        public string Soyad { get; set; }
    }
}
