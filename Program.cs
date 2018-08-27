using System;
using System.Collections.Generic;

namespace le1 {

    class Program {

        static void Main (string[] args) {

            // Create some cohorts, students, and instructors in your `Program.cs` and assign the students and instructors to the cohort

            Cohort cohort26 = new Cohort ();
            Instructor steve = new Instructor ("Steve", "Brownlee");
            Instructor Jisie = new Instructor ("Jisie", "David");
            Student Jewel = new Student ("Jewel", "Ramirez");
            Student Jordan = new Student ("Jordan", "Williams");

            cohort26.InstructorList.Add (steve);
            cohort26.InstructorList.Add (Jisie);

            cohort26.StudentList.Add (Jewel);
            cohort26.StudentList.Add (Jordan);

            // 1. Create some exercises
            // 2. Write a method on the `Instructor` class that will allow you to assign an individual exercise to an individual student

            Exercise lightning = new Exercise ();
            Exercise thunder = new Exercise ();

            lightning.Name = "lightning";
            lightning.GithubURL = "www.lightning.com";
            lightning.Language = "Javascript";

            thunder.Name = "thunder";
            thunder.GithubURL = "www.thunder.com";
            thunder.Language = "C#";

            steve.addExercise(lightning, Jordan);
            Jisie.addExercise(thunder, Jewel);
            Jisie.addExercise(lightning, Jewel);

            foreach (Exercise exercise in Jewel.AssignedExercises)
            {
                Console.WriteLine(exercise.Name);
                Console.WriteLine(exercise.Assigner);
            }




        }
    }
}