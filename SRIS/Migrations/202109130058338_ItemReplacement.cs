namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemReplacement : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        I_id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(),
                        ItemDescription = c.String(),
                        Ir_id = c.Int(),
                    })
                .PrimaryKey(t => t.I_id)
                .ForeignKey("dbo.ItemReplacements", t => t.Ir_id)
                .Index(t => t.Ir_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Ir_id", "dbo.ItemReplacements");
            DropIndex("dbo.Items", new[] { "Ir_id" });
            DropTable("dbo.Items");
        }
    }
}
