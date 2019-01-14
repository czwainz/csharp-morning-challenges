using System;
using challenges.Statics;

namespace challenges
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine(UnderPressure.DoubleInt(2));
      Console.WriteLine(UnderPressure.CanEven(2));
      Console.WriteLine(UnderPressure.GetFileExtension("hello.txt"));
      Console.WriteLine(UnderPressure.GetFileExtension("cra.z.y.txt"));
      Console.WriteLine(UnderPressure.GetFileExtension("noExtension"));


    }
  }
}
