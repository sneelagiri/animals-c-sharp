using System;

/// <summary>
/// This is a derived class Bird from superclass Animal
/// </summary>
public class Bird : Animal
{
    protected bool HasFeathers { get; set; }

	public Bird()
	{
        CanEat = true;
        CanMove = true;
        HasFeathers = true;
    }
}
