using System;
class Program 
{
  static void Main()
  {
      int result;
      int.TryParse("34",out result);
      Console.WriteLine(result);
  }
}
