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
    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            VeBans = new HashSet<VeBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string HoKhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string TenKhachHang { get; set; }

        [StringLength(50)]
        public string TenLotKhachHang { get; set; }

        [Required]
        [StringLength(10)]
        public string SoDienThoai { get; set; }

        [Required]
        [StringLength(50)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(20)]
        public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeBan> VeBans { get; set; }
    }

}
