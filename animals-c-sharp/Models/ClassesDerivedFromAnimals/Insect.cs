using System;

/// <summary>
/// This is a derived class Insect from superclass Animal
/// </summary>
public class Insect : Animal
{
    protected bool HasExoskeleton { get; set; }

    public Insect()
	{
        CanEat = true;
        CanMove = true;
        HasExoskeleton = true;
    }
}
