using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IICPSES.Models.Users
{
    public class Course
    {
        public int Semester { get; set; }
        public string SemesterSession { get; set; }
        public int SubjectName { get; set; }
        public string ProgramName { get; set; }
    }
}