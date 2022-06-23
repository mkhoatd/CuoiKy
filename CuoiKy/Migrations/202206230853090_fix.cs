namespace CuoiKy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "DiemCuoiKy", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "DiemCuoiKy");
        }
    }
}
