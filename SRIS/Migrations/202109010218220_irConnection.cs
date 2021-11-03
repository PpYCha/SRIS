namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class irConnection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TechnicianServices", "Ir_id", c => c.Int());
            CreateIndex("dbo.TechnicianServices", "Ir_id");
            AddForeignKey("dbo.TechnicianServices", "Ir_id", "dbo.ItemReplacements", "Ir_id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianServices", "Ir_id", "dbo.ItemReplacements");
            DropIndex("dbo.TechnicianServices", new[] { "Ir_id" });
            DropColumn("dbo.TechnicianServices", "Ir_id");
        }
    }
}
