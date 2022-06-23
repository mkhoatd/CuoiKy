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
        private static HocPhanBLL _instance { get; set; }
        public static HocPhanBLL Instance
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
            var hocphans=_context.HocPhans.ToList();//Only parameterless constructors and initializers are
                                                    //supported in LINQ to Entities nen phai chuyen thanh
                                                    //DAO truoc do k tao query thang vao db dc
            return hocphans.Select(h=>new HocPhanCBB(h)).ToList();
        }
        
    }
}
