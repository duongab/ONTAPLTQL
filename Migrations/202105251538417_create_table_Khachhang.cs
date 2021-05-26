namespace ONTAPLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhangs",
                c => new
                    {
                        makh = c.String(nullable: false, maxLength: 128, unicode: false),
                        tenkh = c.String(maxLength: 100),
                        sdt = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.makh);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhangs");
        }
    }
}
