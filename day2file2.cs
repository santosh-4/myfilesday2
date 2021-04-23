using System.IO;
using System;

class Program
{
    void CheckOddEven(int a)
    {
        if(a%2==0)
        {
            Console.WriteLine("EVEN");
        }
        else
        {
            Console.WriteLine("ODD");
        }
    }
    static void Main()
    {
     Program check = new Program();
     check.CheckOddEven(11);
    }
}