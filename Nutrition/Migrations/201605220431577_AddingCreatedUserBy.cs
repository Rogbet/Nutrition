namespace Nutrition.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCreatedUserBy : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Patient", name: "User_Id", newName: "UserID");
            RenameIndex(table: "dbo.Patient", name: "IX_User_Id", newName: "IX_UserID");
            AddColumn("dbo.Patient", "CreatedByUserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Patient", "CreatedByUserID");
            AddForeignKey("dbo.Patient", "CreatedByUserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patient", "CreatedByUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Patient", new[] { "CreatedByUserID" });
            DropColumn("dbo.Patient", "CreatedByUserID");
            RenameIndex(table: "dbo.Patient", name: "IX_UserID", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Patient", name: "UserID", newName: "User_Id");
        }
    }
}
