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

        DbSet<Patient> Patients { get; set; }
        DbSet<Contact> Contacts { get; set; }
    }
}