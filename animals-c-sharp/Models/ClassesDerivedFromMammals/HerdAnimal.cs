using System;

/// <summary>
/// This is a derived class Herd Animal from class Mammal
/// </summary>
public class HerdAnimal : Mammal
{
    protected bool DoGraze { get; set; }

    public HerdAnimal()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        DoGraze = true;
    }
}
