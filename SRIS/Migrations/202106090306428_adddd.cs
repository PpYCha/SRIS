namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        User_id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        AccessLevel = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Position = c.String(),
                    })
                .PrimaryKey(t => t.User_id);
            
            CreateTable(
                "dbo.OfficeDeparments",
                c => new
                    {
                        Od_id = c.Int(nullable: false, identity: true),
                        OfficeDepartmentName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Abbreviation = c.String(),
                    })
                .PrimaryKey(t => t.Od_id);
            
            CreateTable(
                "dbo.ServiceRequests",
                c => new
                    {
                        Sr_id = c.Int(nullable: false, identity: true),
                        TypeOfServiceProvided = c.String(),
                        TypeOfServiceProvided_Description = c.String(),
                        RequestedBy = c.String(),
                        DateRequested = c.DateTime(),
                        FaultDiagnosis = c.String(),
                        DateCompleted = c.DateTime(),
                        Status = c.String(),
                        DateEntered = c.String(),
                    })
                .PrimaryKey(t => t.Sr_id);
            
            CreateTable(
                "dbo.TechnicianServices",
                c => new
                    {
                        Ts_id = c.Int(nullable: false, identity: true),
                        Sr_id = c.Int(nullable: false),
                        Tech_id = c.Int(nullable: false),
                        ProvidedBy = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Ts_id)
                .ForeignKey("dbo.ServiceRequests", t => t.Sr_id, cascadeDelete: true)
                .ForeignKey("dbo.Technicians", t => t.Tech_id, cascadeDelete: true)
                .Index(t => t.Sr_id)
                .Index(t => t.Tech_id);
            
            CreateTable(
                "dbo.Technicians",
                c => new
                    {
                        Tech_id = c.Int(nullable: false, identity: true),
                        TechName = c.String(),
                        TechPosition = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Tech_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TechnicianServices", "Tech_id", "dbo.Technicians");
            DropForeignKey("dbo.TechnicianServices", "Sr_id", "dbo.ServiceRequests");
            DropIndex("dbo.TechnicianServices", new[] { "Tech_id" });
            DropIndex("dbo.TechnicianServices", new[] { "Sr_id" });
            DropTable("dbo.Technicians");
            DropTable("dbo.TechnicianServices");
            DropTable("dbo.ServiceRequests");
            DropTable("dbo.OfficeDeparments");
            DropTable("dbo.Accounts");
        }
    }
}
