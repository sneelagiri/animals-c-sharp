using System;

/// <summary>
/// This is a derived class Amphibian from superclass Animal
/// </summary>
public class Amphibian : Animal
{
    protected bool HasFourLimbs { get; set; }

    public Amphibian()
	{
        CanEat = true;
        CanMove = true;
        HasFourLimbs = true;
    }
}
