namespace Refactoring.Animals;

public class Cow : Animal
{
    public Cow(string name)
        : base(name) { }

    public override string MakeNoise() => $"{this.Name} says 'mooh'";
}
