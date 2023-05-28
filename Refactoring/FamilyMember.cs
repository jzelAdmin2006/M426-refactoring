namespace Refactoring;

public class FamilyMember
{
    public string Name { get; }

    public FamilyMember(string name)
    {
        Name = name;
        this.children = new();
    }

    public FamilyMember(string name, List<FamilyMember> children)
    {
        Name = name;
        this.children = children;
    }

    private List<FamilyMember> children;

    public Dictionary<FamilyMember, int> GetDescendants(int generation)
    {
        Dictionary<FamilyMember, int> descendants = new();
        foreach (FamilyMember heir in children)
        {
            descendants.Add(heir, generation + 1);
            foreach (FamilyMember grandChild in heir.children)
            {
                descendants.Add(grandChild, generation + 2);
                foreach (FamilyMember greatGrandChild in grandChild.children)
                {
                    descendants.Add(greatGrandChild, generation + 3);
                }
            }
        }
        return descendants;
    }
}