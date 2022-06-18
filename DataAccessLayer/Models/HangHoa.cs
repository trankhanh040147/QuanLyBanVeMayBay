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
    [Table("HangHoa")]
    public partial class HangHoa
    {
        [Key]
        [StringLength(10)]
        public string MaHangHoa { get; set; }

        [Required]
        [StringLength(10)]
        public string MaVeBan { get; set; }

        public double TrongLuong { get; set; }

        [Required]
        [StringLength(60)]
        public string Loai { get; set; }

        [Required]
        [StringLength(60)]
        public string TenHangHoa { get; set; }

        public virtual VeBan VeBan { get; set; }
    }
}
