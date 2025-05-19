﻿using System;

namespace Company
{
    using IT = Department.IT; // Alias for nested namespace

    namespace Department
    {
        public class IT
        {
            public void Support() => Console.WriteLine("IT Support");
        }

        public class HR
        {
            public void Hire() => Console.WriteLine("HR Hiring");
        }
    }

    public class Office
    {
        public void Manage()
        {
            var it = new IT(); // Uses the alias
            it.Support();

            var hr = new Department.HR(); // Fully qualified
            hr.Hire();
        }
    }
}

class Program
{
    static void Main()
    {
        var office = new Company.Office();
        office.Manage();
        // Output:
        // "IT Support"
        // "HR Hiring"
    }
}