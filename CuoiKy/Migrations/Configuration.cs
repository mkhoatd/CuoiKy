using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CuoiKy.Migrations
{

    

    internal sealed class Configuration : DbMigrationsConfiguration<CuoiKy.DAL.DiemHocPhanDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CuoiKy.DAL.DiemHocPhanDbContext context)
        {
            if(!context.HocPhans.Any())
            {
                context.HocPhans.Add(new DAO.HocPhan
                {
                    Id = System.Guid.NewGuid().ToString(),
                    TenHocPhan = "C"
                });
                context.HocPhans.Add(new DAO.HocPhan
                {
                    Id = System.Guid.NewGuid().ToString(),
                    TenHocPhan = "B"
                });
                context.SaveChanges();
            }
            if(!context.SinhViens.Any())
            {

                context.SinhViens.Add(new DAO.SinhVien
                {
                    Id = System.Guid.NewGuid().ToString(),
                    TenSinhVien = "NVC",
                    LopSinhHoat = "A1",
                    GioiTinh = false,
                    DiemBaiTap = 0,
                    DiemGiuaKy = 0,
                    NgayThi = DateTime.Now,
                    HocPhanId = context.HocPhans.FirstOrDefault(h => true).Id
                });
                context.SinhViens.Add(new DAO.SinhVien
                {
                    Id = System.Guid.NewGuid().ToString(),
                    TenSinhVien = "NVB",
                    LopSinhHoat = "A1",
                    GioiTinh = false,
                    DiemBaiTap = 0,
                    DiemGiuaKy = 0,
                    NgayThi = DateTime.Now,
                    HocPhanId = context.HocPhans.FirstOrDefault(h => h.TenHocPhan=="B").Id
                });
                context.SaveChanges();
            }
        }
    }
}
