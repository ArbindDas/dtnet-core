using System;

namespace EncapsulationExample
{
    public class Person
    {
        // Private fields - not directly accessible outside the class
        private string name;
        private int age;

        // Public property for Name
        public string Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
        }

        // Public property for Age
        public int Age
        {
            get { return age; }
            set 
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age cannot be negative.");
            }
        }

        // Public method to display person info
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            // Set values using public properties
            person.Name = "Alice";
            person.Age = 25;

            // Attempt to set invalid values
            person.Name = "";  // Will trigger validation
            person.Age = -5;   // Will trigger validation

            // Display information
            person.DisplayInfo();
        }
    }
}
