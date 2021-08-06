using System;

/// <summary>
/// Wolf is a derived class from class Predators as a wolf is the apex predator among mammals
/// </summary>
public class Wolf : Predator
{
    public bool KillsDogs { get; set; }

    public Wolf()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        KillsPrey = true;
        KillsDogs = true;
    }
}
