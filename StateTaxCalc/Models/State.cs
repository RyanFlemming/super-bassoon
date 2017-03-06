using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ERD.Models
{
	public class State
	{
		public int Id { get; set; }
		public int CountryId { get; set; }
		private decimal _tax;

		public decimal Tax
		{
			get { return _tax; }
			set { _tax = value; }
		}
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
	}
}
