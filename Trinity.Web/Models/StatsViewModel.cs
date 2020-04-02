using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Trinity.Entities;

namespace Trinity.Web.Models
{
    public class StatsViewModel
    {
        public int CoursesCount { get; set; }
        public int StudentsCount { get; set; }   
        public int SubjectsCount { get; set; }
        public int TeachersCount { get; set; }
        public int MarksCount { get; set; }
        public int AssignmentsCount { get; set; }




        public int AssignmentsCountPerCourse { get; set; }
        public int TeachersCountPerSubjecr { get; set; }
        public int StudentsCountPerSubject { get; set; }
        public double  StudentsAverageMarkPerSubject{ get; set; }
        public double  StudentsAverageMarkPerAssignment{ get; set; }
        public double  StudentsAverageMarkPerAssignmentPerCourse{ get; set; }
    }
    
}