
using System.Collections.Generic;

namespace Grundlagen {
  public class Student {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }
    public GradeLevel? Year { get; set; }
    public List<int> ExamScores { get; set; }

    public Student() {
      this.FirstName = "";
      this.LastName = "";
      this.ID = 1;
      this.Year = GradeLevel.FirstYear;
      this.ExamScores = new List<int> { 1, 2, 3 };
    }
    public Student(string FirstName,
                   string LastName,
                   int ID,
                   GradeLevel Year,
                   List<int> ExamScores) {
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.ID = ID;
      this.Year = Year;
      this.ExamScores = ExamScores;
    }
  }

  public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear }
  ;
}
