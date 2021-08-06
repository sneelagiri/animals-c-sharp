using System;

/// <summary>
/// This is a derived class Fish from superclass Animal
/// </summary>
public class Fish : Animal
{
    protected bool HasGills { get; set; }
    protected bool NeedsWater { get; set; }

    public Fish()
	{
        CanEat = true;
        CanMove = true;
        HasGills = true;
        NeedsWater = true;
    }
}
