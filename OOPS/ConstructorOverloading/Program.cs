using System;

public class Parent
{
    private string title;
    private string content;

    // private bool isvalid;

    // Constructor 1: Two parameters
    public Parent(string title, string content)
    {
        this.title = title;
        this.content = content;
    }

    // Constructor 2: One parameter
    public Parent(string title)
    {
        this.title = title;
        this.content = ""; // Avoid CS8618 warning
    }

    // Properties
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Content
    {
        get { return content; }
        set { content = value; }
    }
}

public class MyClass
{
    public static void Main(string[] args)
    {
        Parent p = new Parent("abhisek", "chinar");

        // Accessing via public properties
        Console.WriteLine("title is : " + p.Title);
        Console.WriteLine("content is : " + p.Content);
    }
}
