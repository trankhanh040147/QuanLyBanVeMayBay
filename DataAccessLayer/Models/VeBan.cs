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
    [Table("VeBan")]
    public partial class VeBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeBan()
        {
            HangHoas = new HashSet<HangHoa>();
        }

        [Required]
        [StringLength(10)]
        public string MaVe { get; set; }

        public int SLVeBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhachHang { get; set; }

        public int TongTien { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ThoiGianBan { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ThoiGianThanhToan { get; set; }

        public int? SoLuongHangHoa { get; set; }

        [Key]
        [StringLength(10)]
        public string MaVeBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoas { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual ThongTinChiTietVe ThongTinChiTietVe { get; set; }
    }
}
