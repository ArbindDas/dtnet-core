using System;

class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Abhi
{
    public static void Main(string[] args)
    {
        Animal myAnimal;

        myAnimal = new Dog();
        myAnimal.Speak();  // Output: The dog barks.

        myAnimal = new Cat();
        myAnimal.Speak();  // Output: The cat meows.
    }
}
