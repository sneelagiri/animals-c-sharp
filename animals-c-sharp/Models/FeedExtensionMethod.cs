using System;

/// <summary>
/// This is an extension method for feeding animals
/// </summary>
public static class FeedExtensionMethod
{
    public static Animal Feed(this Animal animal)
    {
        animal.isFed = true;
        return animal;
    }
}
