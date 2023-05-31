def get_letter_grade(grade: int) -> str:
    match grade:
        case 1:
            return "A"
        case 2:
            return "B"
        case 3:
            return "C"
        case 4:
            return "D"
        case 5:
            return "E"
        case 6:
            return "F"
        case _:
            raise ValueError(f"unknown grade {grade}")
