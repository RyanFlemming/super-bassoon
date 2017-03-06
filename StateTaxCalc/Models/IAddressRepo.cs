using ERD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StateTaxCalc.Models
{
	public interface IAddressRepo
	{
		IList<Country> GetAllCountries();
		IList<State> GetAllStatesByCountryId(int countryId);
		IList<State> GetAllStates();
	}
}