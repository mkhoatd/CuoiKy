using CuoiKy.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace CuoiKy.DAL
{
    public class DiemHocPhanDbContext : DbContext
    {
        // Your context has been configured to use a 'DiemHocPhanDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CuoiKy.DAL.DiemHocPhanDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DiemHocPhanDbContext' 
        // connection string in the application configuration file.
        public DiemHocPhanDbContext()
            : base("name=DiemHocPhanDbContext")
        {
        }

        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}