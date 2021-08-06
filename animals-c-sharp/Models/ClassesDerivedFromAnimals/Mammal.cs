using System;

/// <summary>
/// This is a derived class Mammals from superclass Animal. Herd animals, marine animals, pets, and predators inherit from this class.
/// </summary>
public class Mammal : Animal
{
    protected bool FemalesProduceMilk { get; set; }

    public Mammal()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
    }
}
