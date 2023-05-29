def fib(n: int) -> int:
    if n < 0:
        raise ValueError("Fibonacci undefined for negative numbers")
    if n in [0, 1]:
        return 1
    return fib(n-2) + fib(n-1)