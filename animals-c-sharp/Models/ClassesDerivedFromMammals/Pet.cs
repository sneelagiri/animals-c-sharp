using System;

/// <summary>
/// This is a derived class Pet from class Mammal
/// </summary>
public class Pet : Mammal
{
    protected bool IsForCompanionship { get; set; }

    public Pet()
	{
        CanEat = true;
        CanMove = true;
        FemalesProduceMilk = true;
        IsForCompanionship = true;

    }
}
