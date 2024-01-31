namespace Refactoring.Tests;

public class GradingTest
{
    [Theory]
    [InlineData(1, 'A')]
    [InlineData(2, 'B')]
    [InlineData(3, 'C')]
    [InlineData(4, 'D')]
    [InlineData(5, 'E')]
    [InlineData(6, 'F')]
    public void TestGetLetterGrade(int grade, char expected)
    {
        Assert.Equal(expected, Grading.GetLetterGrade(grade));
    }

    [Fact]
    public void TestGetLetterGradeThrows()
    {
        Assert.Throws<ArgumentException>(() => Grading.GetLetterGrade(0));
        Assert.Throws<ArgumentException>(() => Grading.GetLetterGrade(7));
    }
}
