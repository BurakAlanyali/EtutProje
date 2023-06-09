using EtutProje.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.Entity.ResultClasses
{
    public class ResultObject
    {
        public string Mesaj { get; set; }
        public string Url { get; set; }
        public int Type { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
