namespace StateTaxCalc.Migrations
{
	using ERD;
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StateTaxCalc.TaxCalcDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StateTaxCalc.TaxCalcDbContext context)
        {

			List<State> StatesInUSA = new List<State>
			{
				new State { Name = "Ohio", Tax = 6.2m},
				new State { Name = "California", Tax = 9.6m}
			};

			List<State> StatesInIndia = new List<State>
			{
				new State { Name = "Goa", Tax = 7.1m},
				new State { Name = "Gujarat", Tax = 9.2m}
			};

			List<State> StatesInMexico = new List<State>
			{
				new State { Name = "Oaxaca", Tax = 6.9m},
				new State { Name= "Yucatán", Tax = 13.8m}
			};

			context.Countries.AddOrUpdate(
				(c) => c.Name,
				new Country { Name = "USA", States = StatesInUSA },
				new Country { Name = "India", States = StatesInIndia },
				new Country { Name = "Mexico", States = StatesInMexico}
				);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
