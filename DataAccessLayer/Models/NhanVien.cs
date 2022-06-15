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
    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            ThongBaos = new HashSet<ThongBao>();
            VeBans = new HashSet<VeBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string TenNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string HoNhanVien { get; set; }

        [StringLength(50)]
        public string TenLotNhanVien { get; set; }

        [Required]
        [StringLength(11)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongBao> ThongBaos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeBan> VeBans { get; set; }
    }
}
