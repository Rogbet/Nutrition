namespace Nutrition.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Patient", "ImageID", "dbo.Image");
            DropIndex("dbo.Patient", new[] { "ImageID" });
            AlterColumn("dbo.Patient", "ImageID", c => c.Int());
            CreateIndex("dbo.Patient", "ImageID");
            AddForeignKey("dbo.Patient", "ImageID", "dbo.Image", "ImageID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patient", "ImageID", "dbo.Image");
            DropIndex("dbo.Patient", new[] { "ImageID" });
            AlterColumn("dbo.Patient", "ImageID", c => c.Int(nullable: false));
            CreateIndex("dbo.Patient", "ImageID");
            AddForeignKey("dbo.Patient", "ImageID", "dbo.Image", "ImageID", cascadeDelete: true);
        }
    }
}
