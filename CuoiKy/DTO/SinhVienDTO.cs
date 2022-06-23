using CuoiKy.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.DTO
{
    public class SinhVienDTO
    {
        public string Id { get; set; }
        public string TenSinhVien { get; set; }
        public string LopSinhHoat { get; set; }
        public bool GioiTinh { get; set; }
        public double DiemBaiTap { get; set; }
        public double DiemGiuaKy { get; set; }
        public double DiemCuoiKy { get; set; }
        public double TongKet
        {
            get => DiemBaiTap * 0.2 + DiemGiuaKy * 0.2 + DiemCuoiKy * 0.3;
            private set { }
        }
        public DateTime NgayThi { get; set; }
        public string TenHocPhan { get; set; }
        public SinhVienDTO(SinhVien s)
        {
            Id = s.Id;
            TenSinhVien = s.TenSinhVien;
            LopSinhHoat = s.LopSinhHoat;
            GioiTinh= s.GioiTinh;
            DiemBaiTap = s.DiemBaiTap;
            DiemGiuaKy = s.DiemGiuaKy;
            DiemCuoiKy = s.DiemCuoiKy;
            NgayThi = s.NgayThi;
            TenHocPhan = s.HocPhan.TenHocPhan;
        }
        public SinhVienDTO()
        { }
    }
}
