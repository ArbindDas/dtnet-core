using System;

public class Parent
{
    // Private fields
    private int age;
    private string userName;

    // Constructor
    public Parent(int age, string userName)
    {
        this.age = age;
        this.userName = userName;
    }

    // Public properties (getters and setters)
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        // Create an object
        Parent p = new Parent(25, "arbind");

        // Access properties
        Console.WriteLine("Age: " + p.Age);
        Console.WriteLine("Username: " + p.UserName);

    }
}
