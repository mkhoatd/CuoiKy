using CuoiKy.DAL;
using CuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuoiKy.BLL
{
    public class HocPhanBLL
    {
        private readonly DiemHocPhanDbContext _context;

        private HocPhanBLL()
        {
            _context = new DiemHocPhanDbContext();
        }
        private HocPhanBLL _instance { get; set; }
        public HocPhanBLL Instance
        {
            get
            {
                if (_instance == null) _instance = new HocPhanBLL();
                return _instance;
            }
            private set { }
        }
        public List<HocPhanCBB> GetAllHocPhanCBBs()
        {
            return _context.HocPhans.Select(h => new HocPhanCBB(h)).ToList();
        }
        public List<SinhVienDTO> GetAllSinhVienDTOs(string name="",string TenHocPhan="", string orderBy="")
        {
            var result = _context.SinhViens.Select(s => new SinhVienDTO(s))
                .Where(s => String.IsNullOrEmpty(name) ? true : s.TenSinhVien.Contains(name))
                .Where(s => string.IsNullOrEmpty(TenHocPhan) ? true : s.TenHocPhan.Contains(TenHocPhan));
            return result.ToList();
             
        }
        
    }
}
