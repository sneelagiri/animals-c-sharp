using System;

/// <summary>
/// Dolphin is a derived class from class Marine Animals as a dolphin is a marine mammal and not a fish
/// </summary>
public class Dolphin : MarineAnimal
{
    Random rnd = new Random();

    public bool CanDoTricks { get; set; }

    public Dolphin(bool canDoTricks)
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        NeedsWater = true;
        CanDoTricks = canDoTricks;
        Weight = rnd.Next(20, 5400);
        Age = rnd.Next(5, 80);
    }

}
