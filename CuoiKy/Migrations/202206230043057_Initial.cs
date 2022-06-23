namespace CuoiKy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TenHocPhan = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        TenSinhVien = c.String(),
                        LopSinhHoat = c.String(),
                        GioiTinh = c.Boolean(nullable: false),
                        DiemBaiTap = c.Double(nullable: false),
                        DiemGiuaKy = c.Double(nullable: false),
                        NgayThi = c.DateTime(nullable: false),
                        HocPhanId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HocPhans", t => t.HocPhanId)
                .Index(t => t.HocPhanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "HocPhanId", "dbo.HocPhans");
            DropIndex("dbo.SinhViens", new[] { "HocPhanId" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.HocPhans");
        }
    }
}
