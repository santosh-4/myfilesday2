using System;
class Program
{
  static void Main() 
  {
      int count = 0;
      string s;
      Console.WriteLine("enter the srting");
      s = Console.ReadLine();
      for(int i=0; i<s.Length;i++)
      {
          if(s[i] =='a'|| s[i] =='i'|| s[i] =='e'|| s[i] =='o'||s[i] =='u')
          {
              count++;
          }
          Console.WriteLine(count);
      }
  }
}

