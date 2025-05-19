using System;

interface IAnimal
{
    void Eat();
}

interface IWalk
{
    void Walk();
}

class Mammal : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Mammal is eating.");
    }
}

class Dog : Mammal, IWalk
{
    public void Walk()
    {
        Console.WriteLine("Dog is walking.");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();
        myDog.Walk();
        myDog.Bark();
    }
}
