﻿using System;

namespace University
{
    using Science = Faculty.Science; // Alias to avoid conflict

    namespace Faculty
    {
        public class Science
        {
            public void Research() => Console.WriteLine("Science Research");
        }

        public class Engineering
        {
            public void Build() => Console.WriteLine("Engineering Project");
        }
    }

    namespace Students
    {
        using Faculty; // Applies only inside 'Students'

        public class ScienceStudent
        {
            public void Study()
            {
                var science = new Science(); // Refers to Faculty.Science
                science.Research();

                var eng = new Engineering(); // Also works
                eng.Build();
            }
        }
    }
}

class Program
{
    static void Main()
    {
        var student = new University.Students.ScienceStudent();
        student.Study();
        // Output:
        // "Science Research"
        // "Engineering Project"
    }
}