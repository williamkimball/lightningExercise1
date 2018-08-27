
using System.Collections.Generic;

namespace le1 {

    public class Cohort {

        public List<Student> StudentList { get; set; } = new List<Student> ();
        public List<Instructor> InstructorList { get; set; } = new List<Instructor> ();

        public int cohortNum { get; set; }

    }

}