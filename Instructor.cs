// 1. private fields for first name and last name
// 2. Public calculated property that returns "Firstname Lastname" of instructor
// 3. Constructor that accepts first name and last name

using System;
namespace le1 {

    public class Instructor : Person {
        public Instructor (string first, string last) {
            _firstname = first;
            _lastname = last;
        }
    
        public void addExercise (Exercise exName, Student studName) {
            studName.AssignedExercises.Add(exName);

            exName.Assigner = this.FullName;
        }

    }

}