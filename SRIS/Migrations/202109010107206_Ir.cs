namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ir : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemReplacements",
                c => new
                    {
                        Ir_id = c.Int(nullable: false, identity: true),
                        RequestingOffice = c.String(),
                        DateReplace = c.DateTime(),
                        PropertyNo = c.String(),
                        TypeOfUnit = c.String(),
                        UnitReleasedTo = c.String(),
                        PositionReleasedTo = c.String(),
                        DateReleasedTo = c.String(),
                    })
                .PrimaryKey(t => t.Ir_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemReplacements");
        }
    }
}
