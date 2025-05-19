using System;

class Animal
{
    public string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public void ShowName()
    {
        Console.WriteLine("Animal name: " + name);
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) // calling parent constructor
    {
    }

    public void Display()
    {
        base.ShowName(); // calling parent method
        Console.WriteLine("This is a dog.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy");
        myDog.Display();
    }
}
