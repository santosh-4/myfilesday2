using System;
class Program
{
  static void Main() 
  {
      int [] count = new int[256];
      string s;
      Console.WriteLine("enter the srting");
      s = Console.ReadLine();
      for(int i=0; i<s.Length;i++)
      {
        count[s[i]]++;
       }
       int max = -1;
       char result = ' ';
       for(int i=0; i<s.Length;i++)
       {
           if (max < count[s[i]])
           {
                max = count[s[i]];
                result = s[i];
           }
       }
      Console.WriteLine("the string is : "+s);
      Console.WriteLine("The highest occuring Character is "+result+" and count is:"+max);
  }

}
