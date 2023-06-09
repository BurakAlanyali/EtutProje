using EtutProje.Entity.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.Entity.Classes.SektorClasses
{
    public class Sektor: BaseObject
    {
        [Display(Name ="Sektör Tanım")]
        public string SektorTanim { get; set; }
        [Display(Name = "Açıklama")]
        public string SektorAciklama { get; set; }
    }
}
