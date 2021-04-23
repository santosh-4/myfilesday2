using System;
 
class Dog
{
    public  void Speak()
    {
        Console.WriteLine("Bark !");
    }
}
class class7
{
  static void Main ()
  {
      Object o = new Dog();
      Dog dog = o as Dog;
      if(dog != null)
      dog.Speak();
  }
}