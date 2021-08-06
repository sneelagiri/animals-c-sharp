using System;

/// <summary>
/// Dog is a derived class from class Pet as a dog is a mammal and is a pet
/// </summary>
public class Dog : Pet
{
    public string Name { get; set; }
    public string Breed { get; set; }

    public Dog(string name, string breed, int weight, int age )
	{
        Name = name;
        Breed = breed;
        Weight = weight;
        Age = age;
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        IsForCompanionship = true;
    }
}
