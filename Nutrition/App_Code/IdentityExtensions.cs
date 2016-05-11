using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Nutrition.ViewModels;

namespace App.Extensions
{
    public static class IdentityExtensions
    {
        public static string GetFullName(this IIdentity identity)
        {
            var currentUserId = identity.GetUserId();
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(currentUserId);
            return currentUser.FullName;
        }
    }
}