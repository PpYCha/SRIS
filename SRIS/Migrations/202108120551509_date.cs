namespace SRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.InspectionInfoes", "ReceivedDate", c => c.DateTime());
            AlterColumn("dbo.InspectionInfoes", "DateReleased", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.InspectionInfoes", "DateReleased", c => c.String());
            AlterColumn("dbo.InspectionInfoes", "ReceivedDate", c => c.String());
        }
    }
}
