
using System;
  public struct Person
  {
      public String Name { get; set; }
      public Person(string _name)
      {
          Name = _name;
      }
  }
  public struct Dog
  {
      public String breed { get; set; }
      public Dog(String _breed)
      {
          breed = _breed;
      }
class Program 
{
    public static void showvalue(Object o)
    {
        if(o is Person p)
        {
            Console.WriteLine(p.Name);
        }
        else if(o is Dog d)
        {
            Console.WriteLine(d.breed);
        }
    }
  static void Main ()
  {
      Object o = new Person("santosh");
      showvalue(o);
      o = new Dog("husky");
      showvalue(o);
  }
  }