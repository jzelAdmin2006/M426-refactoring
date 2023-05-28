from refactoring.family_member import FamilyMember

if __name__ == "__main__":
    # children generation
    aline = FamilyMember("Aline")
    basil = FamilyMember("Basil")
    charlotte = FamilyMember("Charlotte")
    daniel = FamilyMember("Daniel")
    eleanor = FamilyMember("Eleanor")
    fred = FamilyMember("Fred")
    geany = FamilyMember("Geany")
    hank = FamilyMember("Hank")

    # parent generation
    irene = FamilyMember("Irene", [aline, basil])
    james = FamilyMember("James", [charlotte, daniel])
    katie = FamilyMember("Katie", [eleanor, fred])
    lance = FamilyMember("Lance", [geany, hank])

    # grandparent generation
    monica = FamilyMember("Monica", [irene, james])
    ned = FamilyMember("Ned", [katie, lance])

    # great-grandfather
    otto = FamilyMember("Otto", [monica, ned])

    # output family tree
    descendants = otto.get_descendants(0)
    for descendant, generation in descendants.items():
        name = descendant.name
        separator = generation * "\t"
        print(
            f"{separator} {name} is a descendant of {otto.name} "
            + f"(generation {generation})"
        )
