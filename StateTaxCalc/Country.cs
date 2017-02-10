using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD
{
	public class Country
	{
		// IDs for Country and State, so that
		// we can navigate from Country to State
		public int CountryId { get; set; }
		private string _name;
		public List<State> States { get; set; }

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		
	}
}
