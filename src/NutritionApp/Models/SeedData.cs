using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace NutritionApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            string[] roles = new string[] { "Administrator", "Editor" };

            foreach (string role in roles)
            {
                var roleStore = new RoleStore<IdentityRole>(context);

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.CreateAsync(new IdentityRole(role));
                }
            }

            var users = new List<ApplicationUser>();

            users.Add(new ApplicationUser
            {
                Email = "roge.villafu@gmail.com",
                NormalizedEmail = "ROGE.VILLAFU@GMAIL.COM",
                UserName = "roge.villafu@gmail.com",
                NormalizedUserName = "ROGE.VILLAFU@GMAIL.COM",
                PhoneNumber = "+99999999999",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            });

            users.Add(new ApplicationUser
            {
                Email = "sandra_sandy4@hotmail.com",
                NormalizedEmail = "SANDRA_SANDY4@HOTMAIL.COM",
                UserName = "sandra_sandy4@hotmail.com",
                NormalizedUserName = "ROGE.VILLAFU@HOTMAIL.COM",
                PhoneNumber = "+99999999999",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            });

            foreach (var user in users)
            {
                if (!context.Users.Any(u => u.UserName == user.UserName))
                {
                    var password = new PasswordHasher<ApplicationUser>();
                    var hashed = password.HashPassword(user, "nutripass123");
                    user.PasswordHash = hashed;

                    var userStore = new UserStore<ApplicationUser>(context);
                    var result = userStore.CreateAsync(user);
                }

                AssignRoles(serviceProvider, user.Email, roles);
            }

            context.SaveChangesAsync();
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] roles)
        {
            UserManager<ApplicationUser> _userManager = services.GetService<UserManager<ApplicationUser>>();
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.AddToRolesAsync(user, roles);

            return result;
        }

    }
}
