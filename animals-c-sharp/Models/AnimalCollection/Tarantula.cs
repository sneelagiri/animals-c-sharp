using System;

/// <summary>
/// Tarantula is a derived class from class Animals as it does not meet the criteria to be a mammal or insect
/// </summary>
public class Tarantula : Animal
{
    public int NumberOfLegs { get; set; }
    public bool ProducesSilk { get; set; }

    public Tarantula()
	{
        CanEat = true;
        CanMove = true;
        NumberOfLegs = 8;
        ProducesSilk = true;
    }
}
