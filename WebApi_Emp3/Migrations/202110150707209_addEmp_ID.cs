namespace WebApi_Emp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEmp_ID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EmpModels");
            AddColumn("dbo.EmpModels", "emp_ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.EmpModels", "nameEmp", c => c.String());
            AddPrimaryKey("dbo.EmpModels", "emp_ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EmpModels");
            AlterColumn("dbo.EmpModels", "nameEmp", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.EmpModels", "emp_ID");
            AddPrimaryKey("dbo.EmpModels", "nameEmp");
        }
    }
}
