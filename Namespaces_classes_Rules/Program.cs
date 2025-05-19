﻿using System;
using School.Administration;
using School.Academics;
using MathTeacher = School.Academics.MathDepartment.Teacher; // Alias to avoid ambiguity

namespace School
{
    // ===== Example of Name Scoping =====
    // Names declared in an outer namespace (School) are accessible in inner namespaces.
    public class SchoolInfo
    {
        public static string SchoolName = "HighTech School";
    }

    namespace Administration
    {
        public class Staff
        {
            public void Display()
            {
                // Can access SchoolInfo because it's in the parent namespace (Name Scoping)
                Console.WriteLine($"{SchoolInfo.SchoolName} - Administration Staff");
            }
        }
    }

    namespace Academics
    {
        // ===== Example of Name Hiding =====
        // If a class in an inner namespace has the same name as one in an outer namespace,
        // the inner one "hides" the outer one unless fully qualified.
        public class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("General Teacher - Teaching a subject");
            }
        }

        namespace MathDepartment
        {
            public class Teacher // Hides Academics.Teacher in this scope
            {
                public void Teach()
                {
                    Console.WriteLine("Math Teacher - Teaching Algebra");
                }

                public void ShowSchoolName()
                {
                    // Still accessible via full qualification (Name Scoping)
                    Console.WriteLine($"School: {School.SchoolInfo.SchoolName}");
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // ==== Name Scoping Example ====
        var adminStaff = new Staff();
        adminStaff.Display(); // Output: "HighTech School - Administration Staff"

        // ==== Name Hiding Example ====
        var generalTeacher = new Teacher(); // Refers to Academics.Teacher
        generalTeacher.Teach(); // Output: "General Teacher - Teaching a subject"

        var mathTeacher = new MathTeacher(); // Refers to MathDepartment.Teacher (via alias)
        mathTeacher.Teach(); // Output: "Math Teacher - Teaching Algebra"
        mathTeacher.ShowSchoolName(); // Output: "School: HighTech School"

        // ==== Accessing Hidden Name ====
        // To access the hidden Academics.Teacher inside MathDepartment, use full qualification:
        var hiddenGeneralTeacher = new School.Academics.Teacher();
        hiddenGeneralTeacher.Teach(); // Output: "General Teacher - Teaching a subject"
    }
}