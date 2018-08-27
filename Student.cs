using System;
using System.Collections.Generic;

namespace le1 {

    public class Student : Person {
        public List<Exercise> AssignedExercises { get; } = new List<Exercise> ();

        public Student (string first, string last) {
            _firstname = first;
            _lastname = last;
        }

    }

}