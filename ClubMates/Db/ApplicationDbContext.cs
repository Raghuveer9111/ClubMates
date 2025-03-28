using ClubMates.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClubMates.Db
{
	public class ApplicationDbContext :DbContext
	{
        public ApplicationDbContext() : base("DefaultConnections")
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}