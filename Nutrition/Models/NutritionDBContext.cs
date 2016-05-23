using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Nutrition.ViewModels;

namespace Nutrition.Models
{
    public class NutritionDBContext : ApplicationDbContext
    {
        public NutritionDBContext()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Image> PatientsImage { get; set; }
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; }
        public DbSet<ClinicHistory> ClinicHistories { get; set; }
        public DbSet<LifeStyle> LifeStyles { get; set; }
        public DbSet<Pathology> ClinicHiPathologies { get; set; }
        public DbSet<ToxicActivity> ToxicActivities { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}