from refactoring.fibonacci import fib


def test_first_fibonacci_number_is_one():
    # TODO: write test
    pass


def test_big_fibonacci_number():
    # Arrange
    n = 38
    expected = 63245986

    # Act
    actual = fib(n)

    # Assert
    assert actual == expected
