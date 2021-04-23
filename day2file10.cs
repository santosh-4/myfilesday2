using System;
 

class Program
{
  static void Main ()
  {
     object str = "hello";
     char[] values = {'h','e','l','l','o'};
     object str2 = new string(values);
     Console.WriteLine("using equals method: "+str.Equals(str2));
     Console.WriteLine("using equality operator: "+(str==str2));
  }
}
