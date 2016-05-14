namespace Nutrition.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pathology",
                c => new
                    {
                        PathologyID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Description = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PathologyID);
            
            CreateTable(
                "dbo.ClinicHistory",
                c => new
                    {
                        ClinicHistoryID = c.Int(nullable: false, identity: true),
                        ReasonOfVisit = c.String(),
                        OtherPathologies = c.String(),
                        SurgeriesPerformed = c.String(),
                        Allergies = c.String(),
                        FamilyBackground = c.String(),
                        BloodType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClinicHistoryID);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        Active = c.Boolean(nullable: false),
                        FoodGroup = c.Int(nullable: false),
                        Calories = c.Int(nullable: false),
                        Carbs = c.Int(nullable: false),
                        Protein = c.Int(nullable: false),
                        Fat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID);
            
            CreateTable(
                "dbo.LifeStyle",
                c => new
                    {
                        LifeStyleID = c.Int(nullable: false, identity: true),
                        Employment = c.String(),
                        EmploymentDescription = c.String(),
                        StressLevel = c.String(),
                        IsVegan = c.Boolean(nullable: false),
                        SportActivity = c.String(),
                        CigarActivityID = c.Int(nullable: false),
                        AlcoholActivityID = c.Int(nullable: false),
                        DrugActivityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LifeStyleID)
                .ForeignKey("dbo.ToxicActivity", t => t.AlcoholActivityID, cascadeDelete: false)
                .ForeignKey("dbo.ToxicActivity", t => t.CigarActivityID, cascadeDelete: false)
                .ForeignKey("dbo.ToxicActivity", t => t.DrugActivityID, cascadeDelete: false)
                .Index(t => t.CigarActivityID)
                .Index(t => t.AlcoholActivityID)
                .Index(t => t.DrugActivityID);
            
            CreateTable(
                "dbo.ToxicActivity",
                c => new
                    {
                        ToxicActivityID = c.Int(nullable: false, identity: true),
                        Frecuency = c.Int(nullable: false),
                        Amount = c.String(),
                    })
                .PrimaryKey(t => t.ToxicActivityID);
            
            CreateTable(
                "dbo.PatientMeasurement",
                c => new
                    {
                        PatientMeasurementID = c.Int(nullable: false, identity: true),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActivityFactor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BodyFat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MuscleMass = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BoneMass = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VisceralFat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MetabolicAge = c.Int(nullable: false),
                        Biceps = c.Int(nullable: false),
                        Triceps = c.Int(nullable: false),
                        Suprailiac = c.Int(nullable: false),
                        Ileocrestal = c.Int(nullable: false),
                        Abdominal = c.Int(nullable: false),
                        Wrist = c.Int(nullable: false),
                        Waist = c.Int(nullable: false),
                        Hip = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientMeasurementID)
                .ForeignKey("dbo.Patient", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Gender = c.Int(nullable: false),
                        State = c.String(),
                        City = c.String(),
                        PhoneNumber = c.String(),
                        CellPhone = c.String(),
                        Notes = c.String(),
                        ImageID = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.Image", t => t.ImageID, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.ImageID)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Image",
                c => new
                    {
                        ImageID = c.Int(nullable: false, identity: true),
                        ImageData = c.Binary(),
                    })
                .PrimaryKey(t => t.ImageID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        LastName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.ClinicHistoryPathology",
                c => new
                    {
                        ClinicHistory_ClinicHistoryID = c.Int(nullable: false),
                        Pathology_PathologyID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ClinicHistory_ClinicHistoryID, t.Pathology_PathologyID })
                .ForeignKey("dbo.ClinicHistory", t => t.ClinicHistory_ClinicHistoryID, cascadeDelete: true)
                .ForeignKey("dbo.Pathology", t => t.Pathology_PathologyID, cascadeDelete: true)
                .Index(t => t.ClinicHistory_ClinicHistoryID)
                .Index(t => t.Pathology_PathologyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Patient", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.PatientMeasurement", "PatientID", "dbo.Patient");
            DropForeignKey("dbo.Patient", "ImageID", "dbo.Image");
            DropForeignKey("dbo.LifeStyle", "DrugActivityID", "dbo.ToxicActivity");
            DropForeignKey("dbo.LifeStyle", "CigarActivityID", "dbo.ToxicActivity");
            DropForeignKey("dbo.LifeStyle", "AlcoholActivityID", "dbo.ToxicActivity");
            DropForeignKey("dbo.ClinicHistoryPathology", "Pathology_PathologyID", "dbo.Pathology");
            DropForeignKey("dbo.ClinicHistoryPathology", "ClinicHistory_ClinicHistoryID", "dbo.ClinicHistory");
            DropIndex("dbo.ClinicHistoryPathology", new[] { "Pathology_PathologyID" });
            DropIndex("dbo.ClinicHistoryPathology", new[] { "ClinicHistory_ClinicHistoryID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Patient", new[] { "User_Id" });
            DropIndex("dbo.Patient", new[] { "ImageID" });
            DropIndex("dbo.PatientMeasurement", new[] { "PatientID" });
            DropIndex("dbo.LifeStyle", new[] { "DrugActivityID" });
            DropIndex("dbo.LifeStyle", new[] { "AlcoholActivityID" });
            DropIndex("dbo.LifeStyle", new[] { "CigarActivityID" });
            DropTable("dbo.ClinicHistoryPathology");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Image");
            DropTable("dbo.Patient");
            DropTable("dbo.PatientMeasurement");
            DropTable("dbo.ToxicActivity");
            DropTable("dbo.LifeStyle");
            DropTable("dbo.Food");
            DropTable("dbo.ClinicHistory");
            DropTable("dbo.Pathology");
        }
    }
}
