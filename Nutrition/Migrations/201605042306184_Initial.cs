namespace Nutrition.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Contacts", newName: "Contact");
            RenameTable(name: "dbo.Patients", newName: "Patient");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Patient", newName: "Patients");
            RenameTable(name: "dbo.Contact", newName: "Contacts");
        }
    }
}
