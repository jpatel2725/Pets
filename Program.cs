using System;

public static class PetTypes
{
    // Constant values for pet types
    public const string Cat = "Cat";
    public const string Dog = "Dog";
    public const string Rabbit = "Rabbit";
}   

public class Pet
{
    // Properties of the Pet class
    public string Name { get; set; }
    public string Type { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Health { get; set; }

    // Constructor to initialize pet properties
    public Pet(string name, string type)
    {
        Name = name;
        Type = type;
        Hunger = 5;
        Happiness = 5;
        Health = 8;
    }

    // Method to feed the pet
    public void Feed()
    {
        Hunger = Math.Max(Hunger - 2, 0);
        Health = Math.Min(Health + 1, 10);
        Console.WriteLine($"You fed {Name}. His Hunger decreases and Health improves slightly");
    }

    // Method to play with the pet
    public void Play()
    {
        Happiness = Math.Min(Happiness + 2, 10);
        Hunger = Math.Min(Hunger + 1, 10);
        Console.WriteLine($"You played with {Name}. His happiness increases, but he's a bit hungry");
    }

    // Method to let the pet rest
    public void Rest()
    {
        Health = Math.Min(Health + 2, 10);
        Happiness = Math.Max(Happiness - 1, 0);
        Console.WriteLine($"{Name} rested for a while, his health increased but his happiness decreased");
    }

    // Method to display pet's status
    public void DisplayStatus()
    {
        Console.WriteLine($"Status of {Name}:");
        Console.WriteLine($"Hunger: {Hunger}");
        Console.WriteLine($"Happiness: {Happiness}");
        Console.WriteLine($"Health: {Health}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Pet type selection
        string petType = SelectPetType();
        Console.WriteLine($"You have chosen a {petType}.");

        // Pet naming
        Console.Write("Enter the name of your pet: ");
        string name = Console.ReadLine();

        // Create a new pet instance
        Pet pet = new Pet(name, petType);
        Console.WriteLine($"You have created a {petType} named {name}.");

        // Main interaction loop
        while (true)
        {
            Console.WriteLine($"\nWhat would you like to do with {name}?");
            Console.WriteLine($"1. Feed the {name}");
            Console.WriteLine($"2. Play with the {name}");
            Console.WriteLine($"3. Let the {name} rest");
            Console.WriteLine($"4. Check {name}'s status");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            // Read user input
            string choice = Console.ReadLine();

            // Handle user input
            switch (choice)
            {
                case "1":
                    pet.Feed();
                    pet.Hunger = Math.Min(pet.Hunger + 1, 10);
                    pet.Happiness = Math.Max(pet.Happiness - 1, 0);
                    break;
                case "2":
                    pet.Play();
                    pet.Hunger = Math.Min(pet.Hunger + 1, 10);
                    pet.Happiness = Math.Max(pet.Happiness - 1, 0);
                    break;
                case "3":
                    pet.Rest();
                    pet.Hunger = Math.Min(pet.Hunger + 1, 10);
                    pet.Happiness = Math.Max(pet.Happiness - 1, 0);
                    break;
                case "4":
                    pet.DisplayStatus();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            

            // Status check
            if (pet.Hunger == 10)
            {
                Console.WriteLine($"{pet.Name} is starving!");
            }
            if (pet.Happiness == 0)
            {
                Console.WriteLine($"{pet.Name} is very unhappy!");
            }
        }
    }

    // Method to select pet type
    static string SelectPetType()
    {
        while (true)
        {
            Console.WriteLine("Select the type of pet:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");
            Console.Write("User Input: ");

            // Read user input
            string choice = Console.ReadLine();

            // Return corresponding pet type based on user input
            switch (choice)
            {
                case "1":
                    return PetTypes.Cat;
                case "2":
                    return PetTypes.Dog;
                case "3":
                    return PetTypes.Rabbit;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
