using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Code First
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer
{
    [Table("DuongBay")]
    public partial class DuongBay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DuongBay()
        {
            ChuyenBays = new HashSet<ChuyenBay>();
        }

        [Key]
        [StringLength(10)]
        public string MaDuongBay { get; set; }

        [Required]
        [StringLength(50)]
        public string ViTri { get; set; }

        public double ChieuDai { get; set; }

        public double ChieuRong { get; set; }

        [Required]
        [StringLength(50)]
        public string TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenBay> ChuyenBays { get; set; }
    }
}
