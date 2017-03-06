using ERD.Models;
using StateTaxCalc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace StateTaxCalc.Controllers
{
    public class CountriesController : Controller
    {
		private IAddressRepo _myRepo;

		public CountriesController() : this(new AddressRepo())
		{

		}
		public CountriesController(IAddressRepo repo)
		{
			_myRepo = repo;
		}
		public ActionResult Index()
		{
			AddressModel MyAddressModel = new AddressModel();
			MyAddressModel.AvailableCountries.Add(new SelectListItem { Text = "Select a Country", Value = "Select item" });
			var countries = _myRepo.GetAllCountries();
			foreach (var country in countries)
			{
				MyAddressModel.AvailableCountries.Add(new SelectListItem()
					{
						Text = country.Name,
						Value = country.Id.ToString()
					});
			}
			return View(MyAddressModel);
		}

		// This is the Action we'll call with Ajax
		// This action only responds to GET requests
		[AcceptVerbs(HttpVerbs.Get)]
		public ActionResult GetStatesByCountryId(string countryId)
		{
			if (String.IsNullOrEmpty(countryId))
			{
				throw new ArgumentNullException("countryId");
			}
			int id = 0;
			bool isValid = Int32.TryParse(countryId, out id);
			IList<State> states = _myRepo.GetAllStatesByCountryId(id);
			var result = (from s in states
						  select new
						  {
							  id = s.Id,
							  name = s.Name,
							  tax = s.Tax.ToString()
						  }).ToList();
			return Json(result, JsonRequestBehavior.AllowGet);
		}
    }
}