namespace Nutrition.Migrations
{
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Nutrition.ViewModels;
    internal sealed class Configuration : DbMigrationsConfiguration<Nutrition.Models.NutritionDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        bool AddUserAndRole(Nutrition.Models.NutritionDBContext context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "roge.villafu@gmail.com",
            };

            ir = um.Create(user, "secret123");

            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");

            return ir.Succeeded;
        }

        

        protected override void Seed(Nutrition.Models.NutritionDBContext context)
        {
            AddUserAndRole(context);
        }

        
    }
}
