using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Code first - Data Anonation
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataAccessLayer
{
    [Table("ThongTinChiTietVe")]
    public partial class ThongTinChiTietVe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinChiTietVe()
        {
            VeBans = new HashSet<VeBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaVe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaChuyenBay { get; set; }

        [Required]
        [StringLength(30)]
        public string LoaiVe { get; set; }

        public int SoLuong { get; set; }

        public int SoLuongCon { get; set; }

        public int Gia { get; set; }

        public virtual ChuyenBay ChuyenBay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeBan> VeBans { get; set; }
    }
}
