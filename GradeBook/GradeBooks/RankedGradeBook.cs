using System;
namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (averageGrade >= 20)
                return 'A';
            else if (averageGrade >= 40)
                return 'B';
            else if (averageGrade >= 50)
                return 'C';
            else if (averageGrade >= 50)
                return 'C';
            else if (averageGrade >= 80)
                return 'D';
            else
                return 'F';
        }
    }
}
