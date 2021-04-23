using System;
class Program
{
    //call by reference
      void swap(ref int a,ref int b)
    {
        int temp = a;
        a=b;
        b=temp;
        Console.WriteLine("-----------inside swapping");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
    }
    static void Main()
    {
        Program swapp = new Program();
        int a = 10, b = 20;
        swapp.swap(ref a, ref b);
         Console.WriteLine("-----------in main function");
        Console.WriteLine("a="+a);
        Console.WriteLine("b="+b);
        
    }
}
