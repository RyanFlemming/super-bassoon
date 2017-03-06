using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERD.Models
{
	public class Country
	{
		public int Id { get; set; }
		private string _name;
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
	}
}
