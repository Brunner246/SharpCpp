using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// namespace COM {
//   [ComImport]
//   [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
//   [Guid("0f8fad5b-d9cb-469f-a165-70867728950e")]
//   interface IComInterface {
//     void Method();
//     void Method2();
//   }
// }

namespace MyInterop {
  /// <summary>
  /// Summary description for Class1.
  /// </summary>
  ///
  [Guid("3E0E2EB2-CC13-40fb-9346-34809CB2418C")]
  public interface IMyDotNetInterface {
    void ShowDialog();
  }

  [ClassInterface(ClassInterfaceType.None)]
  [Guid("3A13EB34-3930-4e06-A3EB-10724CCC2F4B")]
  public class MyDotNetClass : IMyDotNetInterface {
    public MyDotNetClass() {}

    public void ShowDialog() { Console.WriteLine("I am a  Managed DotNET C# COM Object Dialog"); }
  }
}

namespace Grundlagen {

  //[ComVisible(true)]
  //[Guid("2e08432c-af2f-44d7-9602-22106f1bde86")]  // Fügen Sie hier Ihre eigene GUID hinzu
  //[ClassInterface(ClassInterfaceType.None)]
  // public class Student {
  //  public string FirstName { get; set; }
  //  public string LastName { get; set; }
  //  public int ID { get; set; }
  //  public GradeLevel Year { get; set; }
  //  public List<int> ExamScores { get; set; }

  //  public Student() {
  //    this.FirstName = "";
  //    this.LastName = "";
  //    this.ID = 1;
  //    this.Year = GradeLevel.FirstYear;
  //    this.ExamScores = new List<int> { 1, 2, 3 };
  //  }

  //  public Student(string FirstName,
  //                 string LastName,
  //                 int ID,
  //                 GradeLevel Year,
  //                 List<int> ExamScores) {
  //    this.FirstName = FirstName;
  //    this.LastName = LastName;
  //    this.ID = ID;
  //    this.Year = Year;
  //    this.ExamScores = ExamScores;
  //  }
  //}

  //[ComVisible(true)]
  // public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear }
}
