using System;

/// <summary>
/// This is a derived class Marine Animals from class Mammals
/// </summary>
public class MarineAnimal : Mammal
{
    protected bool NeedsWater { get; set; }

    public MarineAnimal()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        NeedsWater = true;
    }
}
