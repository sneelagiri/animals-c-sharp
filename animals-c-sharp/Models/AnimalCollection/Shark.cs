using System;

/// <summary>
/// Shark is a derived class from class Fish as it does not meet the criteria to be a mammal
/// </summary>
public class Shark : Fish, IDangerousAnimal
{
    Random rnd = new Random();

    public string SharkPrey { get; set; }
    public int NumberOfKills { get; set; }

    public Shark(string sharkPrey, int numberOfKills)
	{
        CanEat = true;
        CanMove = true;
        HasGills = true;
        NeedsWater = true;
        SharkPrey = sharkPrey;
        Weight = rnd.Next(100, 30000);
        Age = rnd.Next(5, 50);
        NumberOfKills = numberOfKills;
    }
}
