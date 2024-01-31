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
        AddDescendants(children, generation + 1, descendants);
        return descendants;
    }

    private void AddDescendants(IEnumerable<FamilyMember> familyMembers, int generation, Dictionary<FamilyMember, int> descendants)
    {
        foreach (FamilyMember member in familyMembers)
        {
            descendants.Add(member, generation);
            AddDescendants(member.children, generation + 1, descendants);
        }
    }
}
