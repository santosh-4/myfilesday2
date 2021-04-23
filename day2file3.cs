using System.IO;
using System;

class Program
{
      void swap(int a, int b)
    {
        int temp = a;
        a=b;
        b=temp;
        Console.WriteLine("afteswapping");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
    }
    static void Main()
    {
        Program swapp = new Program();
        swapp.swap(10,20);
        
    }
}