namespace Refactoring;

public class Grading
{
    public static char GetLetterGrade(int grade)
    {
        if(grade >= 1 && grade <= 6)
        {
            return (char)(64 + grade);
        } else
        {
            throw new ArgumentException("unknown grade " + grade);
        }
    }
}
