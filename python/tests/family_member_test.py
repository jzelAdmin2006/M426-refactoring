from refactoring.family_member import FamilyMember


def test_descendants_of_three_generations_back_are_listed():
    # Arrange
    a = FamilyMember("a")
    b = FamilyMember("b", [a])
    c = FamilyMember("c", [b])
    d = FamilyMember("d", [c])

    # Act
    descendants = d.get_descendants(0)

    # Assert
    assert a in descendants
    assert b in descendants
    assert c in descendants


def test_descendants_of_three_generations_have_correct_generation():
    # Arrange
    a = FamilyMember("a")
    b = FamilyMember("b", [a])
    c = FamilyMember("c", [b])
    d = FamilyMember("d", [c])

    # Act
    descendants = d.get_descendants(0)

    # Assert
    assert descendants[a] == 3
    assert descendants[b] == 2
    assert descendants[c] == 1
