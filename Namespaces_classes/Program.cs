﻿using System;
using School.Administration;
using School.Academics;
using MathTeacher = School.Academics.MathDepartment.Teacher; // Alias for Math Teacher

namespace School
{
    namespace Administration
    {
        public class Staff
        {
            public void Display()
            {
                Console.WriteLine("Administration Staff - Manages school operations");
            }
        }
    }

    namespace Academics
    {
        public class Teacher
        {
            public void Teach()
            {
                Console.WriteLine("Teacher - Conducting class for students");
            }
        }

        namespace MathDepartment
        {
            public class Teacher
            {
                public void Teach()
                {
                    Console.WriteLine("Math Teacher - Teaching Algebra");
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        // Option 1: Fully qualified names (no 'using' needed)
        var adminStaff1 = new School.Administration.Staff();
        var generalTeacher1 = new School.Academics.Teacher();
        var mathTeacher1 = new School.Academics.MathDepartment.Teacher();

        adminStaff1.Display();
        generalTeacher1.Teach();
        mathTeacher1.Teach();

        Console.WriteLine("\nUsing 'using' directives:\n");

        // Option 2: Using simplified names (thanks to 'using' directives)
        var adminStaff2 = new Staff();          // From School.Administration
        var generalTeacher2 = new Teacher();    // From School.Academics
        var mathTeacher2 = new MathTeacher();   // From School.Academics.MathDepartment (via alias)

        adminStaff2.Display();
        generalTeacher2.Teach();
        mathTeacher2.Teach();
    }
}

