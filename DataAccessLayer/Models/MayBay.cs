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
    [Table("MayBay")]
    public partial class MayBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MayBay()
        {
            ChuyenBays = new HashSet<ChuyenBay>();
        }

        [Key]
        [StringLength(10)]
        public string MaMayBay { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMayBay { get; set; }

        [StringLength(50)]
        public string HangSanXuat { get; set; }

        public int KichThuoc { get; set; }

        public int SoGheL1 { get; set; }

        public int SoGheL2 { get; set; }

        public int Tong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenBay> ChuyenBays { get; set; }
    }
}
