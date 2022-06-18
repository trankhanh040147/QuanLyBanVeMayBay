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
    [Table("ChuyenBay")]
    public partial class ChuyenBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenBay()
        {
            ThongTinChiTietVes = new HashSet<ThongTinChiTietVe>();
        }

        [Key]
        [StringLength(10)]
        public string MaChuyenBay { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDuongBay { get; set; }

        [Required]
        [StringLength(10)]
        public string MaMayBay { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDen { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDi { get; set; }

        public TimeSpan GioBay { get; set; }

        [Required]
        [StringLength(50)]
        public string DiemDen { get; set; }

        [Required]
        [StringLength(50)]
        public string DiemDi { get; set; }

        public virtual DuongBay DuongBay { get; set; }

        public virtual MayBay MayBay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinChiTietVe> ThongTinChiTietVes { get; set; }
    }
}
