﻿using System;

namespace School
{
    // This 'using' applies only inside the 'School' namespace
    using Administration;

    namespace Administration
    {
        public class Staff
        {
            public void Display() => Console.WriteLine("Admin Staff");
        }
    }

    public class Test
    {
        public void Run()
        {
            var staff = new Staff(); // Works because of nested 'using'
            staff.Display();
        }
    }
}

class Program
{
    static void Main()
    {
        var test = new School.Test();
        test.Run(); // Output: "Admin Staff"

        // Outside 'School', we need full qualification
        var admin = new School.Administration.Staff();
        admin.Display(); // Output: "Admin Staff"
    }
}