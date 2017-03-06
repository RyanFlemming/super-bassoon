using ERD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateTaxCalc.Models
{
	public class AddressRepo : IAddressRepo
	{
		private TaxCalcDbContext _dataContext;

		public AddressRepo()
		{
			_dataContext = new TaxCalcDbContext();
		}

		public IList<Country> GetAllCountries()
		{
			var query = from countries in _dataContext.Countries
						select countries;
			var content = query.ToList<Country>();
			return content;
		}

		public IList<State> GetAllStatesByCountryId(int countryId)
		{
			var query = from states in _dataContext.States
						where states.CountryId == countryId
						select states;
			var content = query.ToList<State>();
			return content;
		}

		public IList<State> GetAllStates()
		{
			var query = from states in _dataContext.States
						select states;
			var content = query.ToList<State>();
			return content;
		}
	}
}