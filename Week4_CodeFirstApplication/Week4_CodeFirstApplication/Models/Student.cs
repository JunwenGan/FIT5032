using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Code_First_Approach_in_Entity_Framework.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
    }
}