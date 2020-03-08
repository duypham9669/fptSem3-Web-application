using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public String name { get; set; }
        public String hinhphat { get; set; }
        public int soluong { get; set; }
        public DateTime ngaynopphat { get; set; }

    }
}