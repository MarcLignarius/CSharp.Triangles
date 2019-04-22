using System;

namespace Tracker
{

  class Triangle
  {
    private int SideOne;
    private int SideTwo;
    private int SideThree;


    public Triangle(int sideOne, int sideTwo, int sideThree)
    {
      SideOne = sideOne;
      SideTwo = sideTwo;
      SideThree = sideThree;
    }

    public string BuildTriangle(int sideOne, int sideTwo, int sideThree)
    {
      if((sideOne + sideTwo <= sideThree) || (sideOne + sideThree <= sideTwo) || (sideTwo + sideThree <= sideOne))
      {
        return "This is not a triangle";
      }
      else if (sideOne == sideTwo && sideTwo == sideThree)
      {
        return "This is an Equilateral triangle";
      }
      else if(sideOne == sideTwo || sideTwo == sideThree || sideOne == sideThree)
      {
        return "This is an Isosceles triangle";
      }
      else if(sideOne != sideTwo && sideTwo != sideThree && sideOne != sideThree)
      {
        return "This is a Scalene triangle";
      }
      else
      {
        return "There is an error";
      };
    }
  }
}
