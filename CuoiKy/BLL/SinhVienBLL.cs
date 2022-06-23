using CuoiKy.DAL;
using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.BLL
{
    public class SinhVienBLL
    {
        private readonly DiemHocPhanDbContext _context;

        private SinhVienBLL()
        {
            _context = new DiemHocPhanDbContext();
        }
        private SinhVienBLL _instance { get; set; }
        public SinhVienBLL Instance
        {
            get
            {
                if (_instance == null) _instance = new SinhVienBLL();
                return _instance;
            }
            private set { }
        }
        public List<SinhVienDTO> GetAllSinhVienDTOs(string name = "", string TenHocPhan = "", string orderBy = "")
        {
            var result = _context.SinhViens.Select(s => new SinhVienDTO(s))
                .Where(s => String.IsNullOrEmpty(name) ? true : s.TenSinhVien.Contains(name))
                .Where(s => string.IsNullOrEmpty(TenHocPhan) ? true : s.TenHocPhan.Contains(TenHocPhan));
            if (orderBy == "Id") result.OrderByDescending(s => s.Id);
            if (orderBy == "Tên sinh viên") result.OrderByDescending(s => s.TenSinhVien);
            if (orderBy == "Lớp sinh hoạt") result.OrderByDescending(s => s.LopSinhHoat);
            if (orderBy == "Điểm bài tập") result.OrderByDescending(s => s.DiemBaiTap);
            if (orderBy == "Điểm giữa kỳ") result.OrderByDescending(s => s.DiemGiuaKy);
            if (orderBy == "Học phần") result.OrderByDescending(s => s.TenHocPhan);
            return result.ToList();
        }
        public void AddOrUpdate(SinhVienDTO sv)
        {
            if (_context.SinhViens.Any(s => s.Id == sv.Id))
            {
                var s = _context.SinhViens.Find(sv.Id);
                s.TenSinhVien = sv.TenSinhVien;
                s.LopSinhHoat = sv.LopSinhHoat;
                s.GioiTinh = sv.GioiTinh;
                s.DiemBaiTap = sv.DiemBaiTap;
                s.DiemGiuaKy = sv.DiemGiuaKy;
                s.NgayThi = sv.NgayThi;
                s.HocPhanId = _context.HocPhans.FirstOrDefault(hp => hp.TenHocPhan == sv.TenHocPhan).Id;
            }
            else
            {
                _context.SinhViens.Add(new DAO.SinhVien
                {
                    Id = System.Guid.NewGuid().ToString(),
                    TenSinhVien = sv.TenSinhVien,
                    LopSinhHoat = sv.LopSinhHoat,
                    GioiTinh = sv.GioiTinh,
                    DiemBaiTap = sv.DiemBaiTap,
                    DiemGiuaKy = sv.DiemGiuaKy,
                    NgayThi = sv.NgayThi,
                    HocPhanId = _context.HocPhans.FirstOrDefault(hp => hp.TenHocPhan == sv.TenHocPhan).Id
                });
            }
            _context.SaveChanges();
        }
        public void Delete(List<string> SinhvienIds)
        {
            var svs=_context.SinhViens.Where(s=>SinhvienIds.Contains(s.Id)).ToList();
            _context.SinhViens.RemoveRange(svs);
            _context.SaveChanges();
        }
    }
}
