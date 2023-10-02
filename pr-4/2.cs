using System;
using System.Collections.Generic;

abstract class Animal
{
    public int ID { get; }
    public string Name { get; }

    public Animal(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public abstract string Food();
}

class Predator : Animal
{
    public Predator(int id, string name) : base(id, name) { }

    public override string Food()
    {
        return "Meat";
    }
}

class Omnivore : Animal
{
    public Omnivore(int id, string name) : base(id, name) { }

    public override string Food()
    {
        return "Mix";
    }
}

class Herbivore : Animal
{
    public Herbivore(int id, string name) : base(id, name) { }

    public override string Food()
    {
        return "Plants";
    }
}

class Program
{
    public static void Main()
    {
        Predator tiger = new Predator(1, "Tiger");
        Omnivore bear = new Omnivore(2, "Bear");
        Herbivore horse = new Herbivore(3, "Horse");
        List<Animal> animals = new List<Animal> { tiger, bear, horse };
        List<Animal> sortAnimals = animals.OrderByDescending(a => a.Food().Length).ThenBy(a => a.Name).ToList();
        foreach(Animal animal in sortAnimals)
        {
            Console.WriteLine($"ID: {animal.ID}, Name: {animal.Name}, Type: {animal.GetType().Name}, Food Required: {animal.Food()}");
        }
    }
}
