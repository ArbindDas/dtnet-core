using System;

interface IAnimal
{
    void Speak(); // Interface method — no body
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Dog barks.");
    }
}

class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Cat meows.");
    }
}

class Program
{
    public static void Main()
    {
        IAnimal animal;

        animal = new Dog();
        animal.Speak();  // Output: Dog barks.

        animal = new Cat();
        animal.Speak();  // Output: Cat meows.
    }
}
