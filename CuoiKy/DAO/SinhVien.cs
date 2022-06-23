using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DAO
{
    public class SinhVien
    {
        public string Id { get; set; }
        public string TenSinhVien { get; set; }
        public string LopSinhHoat { get; set; }
        public bool GioiTinh { get; set; } 
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKy { get; set; }
        public DateTime NgayThi { get; set; }
        public string HocPhanId { get; set; }
        public virtual HocPhan HocPhan { get; set; }
    }
}
