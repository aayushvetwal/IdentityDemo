using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Pluralsight.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "scott@scottbrady91.com";
            var password = "Password123!";

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            //var creationResult = userManager.Create(new IdentityUser(username), password);
            //Console.WriteLine("Creation: {0}", creationResult.Succeeded);

            var user = userManager.FindByName(username);
            //var claimResult = userManager.AddClaim(user.Id, new Claim("given_name", "scott"));
            //Console.WriteLine("Claim Added: {0}", claimResult.Succeeded);

            var checkPassword = userManager.CheckPassword(user, password);
            Console.WriteLine("Password Match: {0}", checkPassword);
        }
    }
}
