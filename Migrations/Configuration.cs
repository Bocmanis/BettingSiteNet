namespace BettingSiteNet.Migrations
{
    using BettingSiteNet.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var countries = new List<Country>()
            {
                new Country() { Name = "Latvija", FlagCode = "LV" },
                new Country() { Name = "Kanāda", FlagCode = "CA" },
                new Country() { Name = "Slovākija", FlagCode = "SK" },
                new Country() { Name = "Čehija", FlagCode = "CZ" },
                new Country() { Name = "Norvēģija", FlagCode = "NO" },
                new Country() { Name = "Slovēnija", FlagCode = "SI" },
                new Country() { Name = "Kazahstāna", FlagCode = "KZ" },
                new Country() { Name = "Šveice", FlagCode = "CH" },
            };
            context.Countries.AddOrUpdate(countries.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
