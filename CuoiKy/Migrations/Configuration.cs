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
            if(!context.SinhViens.Any())
            {
                context.HocPhans.Add(new DTO.HocPhan
                {
                    TenHocPhan = "A",
                });
                context.SaveChanges();
                context.SinhViens.Add(new DTO.SinhVien
                {
                    TenSinhVien = "NVA",
                    LopSinhHoat = "A1",
                    GioiTinh = false,
                    DiemBaiTap = 0,
                    DiemGiuaKy = 0,
                    NgayThi = DateTime.Now,
                    HocPhan = context.HocPhans.FirstOrDefault(h=>true)
                });
                context.SaveChanges();
            }
        }
    }
}
