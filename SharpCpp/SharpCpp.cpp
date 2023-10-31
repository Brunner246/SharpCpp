

#include "pch.h"

// #using "CSharpClass.dll"

class Test {
 public:
  explicit Test(const int aNumber) : mNumber(aNumber) {}

  int operator()() const { return mNumber; }

 private:
  int mNumber{};
};

using namespace System;

int main() {
  CSharp::CSharpMath ^ lMath = gcnew CSharp::CSharpMath();
  auto lResult = lMath->Add(1, 2);
  Console::WriteLine("Result: " + lResult);

  auto lTest = Test(123);
  Console::WriteLine("Cpp Class " + lTest());

  Grundlagen::Student ^ lStudent = gcnew Grundlagen::Student();
  lStudent->FirstName = "hans";
  lStudent->LastName = "muster";
  auto lFirstName = lStudent->FirstName;
  auto lLastname = lStudent->LastName;
  Console::WriteLine(lFirstName + " " + lLastname);

  return 0;
}
