using System;

/// <summary>
/// This is a derived class Predators from class Mammals
/// </summary>
public class Predator : Mammal
{
    protected bool KillsPrey { get; set; }

    public Predator()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        KillsPrey = true;
    }
}
