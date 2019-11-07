using System;
/*
 *  A singleton is a class which only allows a single instance of it to be created ,
 * in the application run time only one
 * single instance of the singleton class will exist for all users 
 *
 *    Not thread safe version of a Singleton
 *
 */

namespace ConsoleApp172
{

  public sealed class SingletonClass
  {
    private static SingletonClass _instance = null;
    private SingletonClass() { }

    public static SingletonClass SingleInstance()
    {
      
        if (_instance == null)
        {
          _instance = new SingletonClass();
        }

        return _instance;
      
    }
  }

  static class Program
  {
    private static void Main()
    {

      var S1 = SingletonClass.SingleInstance();
      var S2 = SingletonClass.SingleInstance();

      if (S1 == S2)
      {
        Console.WriteLine("Object are the same instance");
      }

    }
  }
}
