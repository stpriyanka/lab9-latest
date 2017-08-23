using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebRole1.Models
{
	public class Register
	{
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }

	}
	public class Login
	{
		public int ID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}



	public class Lab9Context : DbContext
	{
		public DbSet<Register> Registers { get; set; }
		public DbSet<Login> Logins { get; set; }
	}
}