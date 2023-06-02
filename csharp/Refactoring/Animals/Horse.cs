namespace Refactoring.Animals;

public class Horse : Animal
{
    public Horse(string name)
        : base(name) { }

    public override string MakeNoise() => $"{this.Name} says 'neigh'";
}
