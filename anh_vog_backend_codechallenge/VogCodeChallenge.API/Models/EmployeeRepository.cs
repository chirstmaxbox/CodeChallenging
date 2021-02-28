using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models.Entities;
using VogCodeChallenge.API.Models.Repository;

namespace VogCodeChallenge.API.Models
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly EmployeeDBContext _context;

		/*
		private Employee[] employees = new Employee[] {
				 new Employee { EmployeeId = 1, FirstName = "Mark", LastName = "Harry", JobTitle = "Software Engineer",
								Address = "7218 Deanlee Crt, Mississauga, ON", DeptId = 1},
				 new Employee { EmployeeId = 2, FirstName = "Peter", LastName = "Chan", JobTitle = "Manager",
								Address = "634 Yonge Street, Toronto, ON", DeptId = 2},
				 new Employee { EmployeeId = 3, FirstName = "Chris", LastName = "Kao", JobTitle = "Director",
								Address = "4210 Sheppard Ave East, Scarborough, ON", DeptId = 1} };
		*/

		public EmployeeRepository(EmployeeDBContext context)
		{
			_context = context;
		}

		public IEnumerable<Employee> GetAll()
		{
			return _context.Employees.ToList();
		}

		public IList<Employee> ListAll()
		{
			return _context.Employees.ToList();
		}
	}
}
