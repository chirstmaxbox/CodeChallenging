using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models.Entities
{
	public class Department
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public String Address { get; set; }
		public List<Employee> Employees { get; set; }
	}
}
