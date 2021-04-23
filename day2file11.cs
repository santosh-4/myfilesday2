using System;
class program 
{
  static void Main() 
  {
    string s, rev="";
    Console.WriteLine("enter the String");
    s = Console.ReadLine();
    for(int i=s.Length-1; i>=0; i--)
    {
        rev = rev + s[i];
    }
    if(rev == s)
    {
        Console.WriteLine("palindrome");
    }
    else
    {
        Console.WriteLine("not a palindrome");
    }
  }
}
