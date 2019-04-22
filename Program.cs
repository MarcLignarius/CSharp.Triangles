using System;
using System.Collections.Generic;

namespace Tracker{

  public class Program

  {
    public static void Main()
    {
      Console.WriteLine("Enter side one: ");
      string stringSideOne = Console.ReadLine();
      int sideOne = int.Parse(stringSideOne);

      Console.WriteLine("Enter side two: ");
      string stringSideTwo = Console.ReadLine();
      int sideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Enter side three: ");
      string stringSideThree = Console.ReadLine();
      int sideThree = int.Parse(stringSideThree);

      Triangle newTriangle = new Triangle(sideOne, sideTwo, sideThree);
      string message = newTriangle.BuildTriangle(sideOne, sideTwo, sideThree);
      Console.WriteLine(message);
    }
  }
}
