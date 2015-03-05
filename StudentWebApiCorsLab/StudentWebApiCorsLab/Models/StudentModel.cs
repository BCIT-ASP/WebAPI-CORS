using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentWebApiCorsLab.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }
    }
}