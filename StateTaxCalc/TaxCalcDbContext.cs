using ERD;
using ERD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StateTaxCalc
{
	public class TaxCalcDbContext : DbContext
	{
		public DbSet<State> States { get; set; }
		public DbSet<Country> Countries { get; set; }
	}
}