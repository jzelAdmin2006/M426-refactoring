class FamilyMember:
    def __init__(self, name: str, children: list["FamilyMember"] = []):
        self.name = name
        self.children = children

    def get_descendants(self, generation: int) -> dict["FamilyMember", int]:
        descendants = {}
        for heir in self.children:
            descendants[heir] = generation + 1
            for grand_child in heir.children:
                descendants[grand_child] = generation + 2
                for great_grand_child in grand_child.children:
                    descendants[great_grand_child] = generation + 3
        return descendants
