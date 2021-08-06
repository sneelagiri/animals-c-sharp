using System;

/// <summary>
/// This is the superclass for the following derived classes: insect, mammal, fish, bird and amphibian
/// </summary>
public class Animal
{
    protected bool CanMove { get; set; }
    protected bool CanEat { get; set; }
    public int Weight { get; set; }
    public int Age { get; set; }

    public Animal()
	{
        CanEat = true;
        CanMove = true;
	}

}
