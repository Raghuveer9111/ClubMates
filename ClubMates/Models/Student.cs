using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubMates.Models
{
	public class Student
	{
        [Key]
        public int StudentId { get; set; } = 0;
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year- DateOfBirth.Year;
            }
        }

    }
}