namespace Refactoring.Animals;

public class Zoo
{
    public static string MakeNoise(Animal animal)
    {
        if (typeof(Cow).IsInstanceOfType(animal))
        {
            return animal.Name + " says 'mooh'";
        }
        if (typeof(Dog).IsInstanceOfType(animal))
        {
            return animal.Name + " says 'woof'";
        }
        if (typeof(Horse).IsInstanceOfType(animal))
        {
            return animal.Name + " says 'neigh'";
        }
        throw new ArgumentException("unknown animal, unknown sound");
    }
}
