using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtutProje.Entity.Classes.BaseClasses
{
    public class BaseObject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)] // ilk doldurulan alan olma özelliği vermek için
        public int Id { get; set; }
        [Display(Name = "Oluşturan Kullanıcı")]
        public string OlusturanKullanici { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public DateTime OlusturmaTarihi { get; set; }
        [Display(Name = "Güncelleyen Kullanıcı")]
        public string GuncelleyenKullanici { get; set; }
        [Display(Name = "Güncelleme Tarihi")]
        public DateTime GuncellemeTarihi { get; set; }
        public bool Aktif { get; set; }
        public bool Silindi { get; set; }
        [NotMapped]
        public string AktifString => Aktif ? "Aktif" : "Pasif";
    }
}
