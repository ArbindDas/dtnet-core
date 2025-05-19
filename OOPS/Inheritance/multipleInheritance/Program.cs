using System;

interface IAnimal
{
    void Eat();
}

interface IDog
{
    void Bark();
}

class Dog : IAnimal, IDog
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating.");
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
        myDog.Bark();
    }
}
