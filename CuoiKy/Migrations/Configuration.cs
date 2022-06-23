namespace CuoiKy.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
                    Id = "1",
                    TenHocPhan = "A"
                });
                context.SaveChanges();
            }
            if(!context.SinhViens.Any())
            {

                context.SinhViens.Add(new DAO.SinhVien
                {
                    Id = "1",
                    TenSinhVien = "NVA",
                    LopSinhHoat = "A1",
                    GioiTinh = false,
                    DiemBaiTap = 0,
                    DiemGiuaKy = 0,
                    NgayThi = DateTime.Now,
                    HocPhanId = context.HocPhans.FirstOrDefault(h => true).Id
                });
                context.SaveChanges();
            }
        }
    }
}
