namespace Personal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "HR.Location",
                c => new
                    {
                        LocationId = c.Long(nullable: false, identity: true),
                        StreetAddress = c.String(maxLength: 100),
                        PostalCode = c.String(maxLength: 6),
                        City = c.String(maxLength: 100),
                        StateProvince = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropTable("HR.Location");
        }
    }
}
