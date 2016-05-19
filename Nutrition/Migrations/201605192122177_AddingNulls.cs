namespace Nutrition.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNulls : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientMeasurement", "ActivityFactor", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "BodyFat", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "WaterPercentage", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "MuscleMass", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "BoneMass", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "VisceralFat", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "MetabolicAge", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Biceps", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Triceps", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Suprailiac", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Ileocrestal", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Abdominal", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Wrist", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Waist", c => c.Int());
            AlterColumn("dbo.PatientMeasurement", "Hip", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PatientMeasurement", "Hip", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Waist", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Wrist", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Abdominal", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Ileocrestal", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Suprailiac", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Triceps", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "Biceps", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "MetabolicAge", c => c.Int(nullable: false));
            AlterColumn("dbo.PatientMeasurement", "VisceralFat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "BoneMass", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "MuscleMass", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "WaterPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "BodyFat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PatientMeasurement", "ActivityFactor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
