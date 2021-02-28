using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models.Entities;
using VogCodeChallenge.API.Models.Repository;

namespace VogCodeChallenge.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private IEmployeeRepository _employeeRepos;
		public EmployeesController(IEmployeeRepository employeeRepos)
		{
			_employeeRepos = employeeRepos;
		}

		[HttpGet]
		public IList<Employee> GetAll()
		{
			return _employeeRepos.ListAll();
		}

		[HttpGet]
		[Route("department/{departmentId}")]
		public IEnumerable<Employee> GetAllEmployeeByDeptId(int departmentId)
		{
			return _employeeRepos.ListAll().Where(e => e.DeptId == departmentId);
		}
	}
}
