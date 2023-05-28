namespace Refactoring;

public class Heritage
{
    public static void Main(string[] args)
    {
        // children generation
        FamilyMember aline = new("Aline");
        FamilyMember basil = new("Basil");
        FamilyMember charlotte = new("Charlotte");
        FamilyMember daniel = new("Daniel");
        FamilyMember eleanor = new("Eleanor");
        FamilyMember fred = new("Fred");
        FamilyMember geany = new("Geany");
        FamilyMember hank = new("Hank");

        // parent generation
        FamilyMember irene = new FamilyMember("Irene", new() { aline, basil });
        FamilyMember james = new FamilyMember("James", new() { charlotte, daniel });
        FamilyMember katie = new FamilyMember("Klara", new() { eleanor, fred });
        FamilyMember lance = new FamilyMember("Lance", new() { geany, hank });

        // grandparent generation
        FamilyMember monica = new FamilyMember("Monica", new() { irene, james });
        FamilyMember ned = new FamilyMember("Ned", new() { katie, lance });

        // great-grandfather
        FamilyMember otto = new FamilyMember("Otto", new() { monica, ned });

        // output family tree
        Dictionary<FamilyMember, int> descendants = otto.GetDescendants(0);
        foreach (FamilyMember descendant in descendants.Keys)
        {
            string name = descendant.Name;
            int generation = descendants[descendant];
            string separator = new string('\t', generation);
            Console.WriteLine($"{separator} {name} is a descendant of {otto.Name} (generation {generation})");
        }
    }
}