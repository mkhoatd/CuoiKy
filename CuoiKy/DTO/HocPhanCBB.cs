using CuoiKy.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class HocPhanCBB
    {
        public string Id { get; set; }
        public string TenHocPhan { get; set; }
        public override string ToString()
        {
            return TenHocPhan;
        }
        public HocPhanCBB(HocPhan h)
        {
            Id = h.Id;
            TenHocPhan = h.TenHocPhan;
        }
    }
}
