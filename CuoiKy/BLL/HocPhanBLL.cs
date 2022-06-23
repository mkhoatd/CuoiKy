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


    }
}
