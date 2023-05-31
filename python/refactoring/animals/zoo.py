from .animal import Animal
from .cow import Cow
from .dog import Dog
from .horse import Horse


def make_noise(animal: Animal) -> str:
    if isinstance(animal, Cow):
        return f"{animal.name}" + " says 'mooh'"
    if isinstance(animal, Dog):
        return f"{animal.name}" + " says 'woof'"
    if isinstance(animal, Horse):
        return f"{animal.name}" + " says 'neigh'"
    raise ValueError("unknown animal, unknown sound")
