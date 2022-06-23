using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class HocPhan
    {
        public string Id { get; set; }
        public string TenHocPhan { get; set; }
        public virtual ICollection<SinhVien> SinhViens { get; set; }=new HashSet<SinhVien>();
    }
}
