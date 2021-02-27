using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models.Entities;

namespace VogCodeChallenge.API.Models.Repository
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetAll();
		IList<Employee> ListAll();
	}
}
