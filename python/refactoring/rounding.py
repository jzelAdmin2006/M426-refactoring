class Rounding:
    def __init__(self, precision: float):
        self.precision = precision

    def round(self, value: float) -> float:
        match self.precision:
            case 1.0:
                return round(value)
            case 0.5:
                return round(value * 2.0) / 2.0
            case 0.1:
                return round(value * 10.0) / 10.0
            case 0.05:
                return round(value * 20.0) / 20.0
            case 0.01:
                return round(value * 100.0) / 100.0
            case _:
                raise ValueError(f"unable to round to a precision of {self.precision}")
