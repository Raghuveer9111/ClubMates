using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubMates.Models
{
	public class Teacher
	{
        [Key]
        public int Teacherid { get; set; }
        public string TeacherName { get; set; }
    }
}