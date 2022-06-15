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
    [Table("ThongBao")]
    public partial class ThongBao
    {
        [Key]
        [StringLength(10)]
        public string MaThongBao { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [Column("ThongBao")]
        [Required]
        [StringLength(500)]
        public string ThongBao1 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ThoiGian { get; set; }

        public int KiemTraChu { get; set; }

        public int KiemTraTram { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
