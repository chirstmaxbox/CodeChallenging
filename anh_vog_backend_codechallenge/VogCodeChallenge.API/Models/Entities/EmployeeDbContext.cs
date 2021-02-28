using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models.Entities
{
	public class EmployeeDBContext : DbContext
	{
		public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
		public DbSet<Employee> Employees { get; set; }
	}
}
