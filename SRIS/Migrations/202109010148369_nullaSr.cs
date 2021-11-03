namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullaSr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TechnicianServices", "Sr_id", "dbo.ServiceRequests");
            DropIndex("dbo.TechnicianServices", new[] { "Sr_id" });
            AlterColumn("dbo.TechnicianServices", "Sr_id", c => c.Int());
            CreateIndex("dbo.TechnicianServices", "Sr_id");
            AddForeignKey("dbo.TechnicianServices", "Sr_id", "dbo.ServiceRequests", "Sr_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianServices", "Sr_id", "dbo.ServiceRequests");
            DropIndex("dbo.TechnicianServices", new[] { "Sr_id" });
            AlterColumn("dbo.TechnicianServices", "Sr_id", c => c.Int(nullable: false));
            CreateIndex("dbo.TechnicianServices", "Sr_id");
            AddForeignKey("dbo.TechnicianServices", "Sr_id", "dbo.ServiceRequests", "Sr_id", cascadeDelete: true);
        }
    }
}
