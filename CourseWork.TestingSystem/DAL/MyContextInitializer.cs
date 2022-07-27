using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class MyContextInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var admin = context.Users.Add(new User() { FirstName = "Bohdan", LastName = "Liubinskyi", Login = "Professor", Password = "server", IsAdmin = true });
            var user = context.Users.Add(new User() { FirstName = "Denys", LastName = "Kostyshyn", Login = "Student", Password = "client", IsAdmin = false });
            var admins_group = context.Groups.Add(new Group() { Name = "admins_group" });
            var first_group = context.Groups.Add(new Group() { Name = "first_group" });

            admins_group.Users.Add(admin);
            first_group.Users.Add(user);
            first_group.Users.Add(admin);

            context.SaveChanges();

        }
    }
}
