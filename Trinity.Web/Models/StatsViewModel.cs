using System.Collections.Generic;
using System.Linq;
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

        //curent experiment
        public IEnumerable<IGrouping<ICollection<CourseStudent>, Course>> StudentsPerCourse { get; set; }



        //  Unfruitfull attemts ---  Learning Area  ( to be continued ) ... ===================================================


        public double StudentsAverageMarkPerSubject { get; set; }
        public double StudentsAverageMarkPerAssignment { get; set; }
        public double StudentsAverageMarkPerAssignmentPerCourse { get; set; }



        //ΓIA TON CONTROLLER KAI TO VIEW ( to be continued ) 
        //Unfruitfull attemts ---  Learning Area
        #region ====== no luck ========================
        //vm.StudentsPerCourse = from course in students
        //             group course by course.CourseStudents into y
        //             select y;

        //vm.StudentsPerCourse = from course in courseStudents.Select(x=>x.Student)
        //                       group course by courseStudents into y
        //                       select y;



        //var result = from actor in actors
        //             group actor by actor.Country into y
        //             select y;
        //IEnumerable<IGrouping<Country, Actor>>
        // eg.
        //x1 ====================>  Australia(key) ---- new List<Actors>()(a1, a78);
        // ... x1 krataei ena zeugaraki
        // List<Key, lista> y 
        //y.add(x1) etc
        //     epestrepse mas ti lista y meta zeygarakia



        #endregion

    }

}