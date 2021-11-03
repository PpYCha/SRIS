namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class recommendation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Recommendations",
                c => new
                    {
                        R_id = c.Int(nullable: false, identity: true),
                        RecommendationDetail = c.String(),
                        II_ID = c.Int(),
                    })
                .PrimaryKey(t => t.R_id)
                .ForeignKey("dbo.InspectionInfoes", t => t.II_ID)
                .Index(t => t.II_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recommendations", "II_ID", "dbo.InspectionInfoes");
            DropIndex("dbo.Recommendations", new[] { "II_ID" });
            DropTable("dbo.Recommendations");
        }
    }
}
