namespace WebApi_Emp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniticiaCrete : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpModels",
                c => new
                    {
                        nameEmp = c.String(nullable: false, maxLength: 128),
                        designation = c.String(),
                        address = c.String(),
                        salary = c.Double(nullable: false),
                        dateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.nameEmp);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmpModels");
        }
    }
}
