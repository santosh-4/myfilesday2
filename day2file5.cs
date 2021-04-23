using System;
class Program
{
    //out function
      void swap(out int a,ref int b)
    {
        Console.WriteLine("-----------inside swapping");
        a = 25;
    }
    static void Main()
    {
        Program swapp = new Program();
        int a = 10, b = 20;
        swapp.swap(out  a,ref b);
         Console.WriteLine("-----------in main function");
         Console.WriteLine("a="+a);
         Console.WriteLine("b="+b);
    }
}
