using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERD
{
	public class State
	{
		public int StateId { get; set; }
		public int CountryId { get; set; }
		private string _name;
		private decimal _tax;

		public decimal Tax
		{
			get { return _tax; }
			set { _tax = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		
	}
}
