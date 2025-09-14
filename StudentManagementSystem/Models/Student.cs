using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string fullName { get; set; }
        public string rollNo { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string course { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}