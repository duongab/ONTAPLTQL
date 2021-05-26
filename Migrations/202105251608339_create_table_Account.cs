namespace ONTAPLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        tendangnhap = c.String(nullable: false, maxLength: 128),
                        matkhau = c.String(nullable: false),
                        RoleID = c.String(),
                    })
                .PrimaryKey(t => t.tendangnhap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accounts");
        }
    }
}
