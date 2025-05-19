using System;

class Animal
{
    public string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public void Eat()
    {
        Console.WriteLine(name + " is eating.");
    }
}

class Mammal : Animal
{
    public Mammal(string name) : base(name) { }

    public void Walk()
    {
        Console.WriteLine(name + " is walking.");
    }
}

class Dog : Mammal
{
    public Dog(string name) : base(name) { }

    public void Bark()
    {
        Console.WriteLine(name + " is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy");

        myDog.Eat();
        myDog.Walk();
        myDog.Bark();
    }
}
