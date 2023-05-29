def convert_to(amount: float, to_currency: str) -> float:
    match to_currency:
        case "USD":
            return amount * 1.09
        case "EUR":
            return amount * 0.96
        case "GBP":
            return amount * 0.82
        case "RUB":
            return amount * 79.78
        case _:
            raise ValueError(f"no exchange rate for {to_currency} available")
