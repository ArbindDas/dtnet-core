using System;

abstract class Animal
{
    public string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public abstract void MakeSound();  

    public void Eat()
    {
        Console.WriteLine(name + " is eating.");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()  
    {
        Console.WriteLine(name + " says Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy");
        myDog.Eat();
        myDog.MakeSound();
    }
}
