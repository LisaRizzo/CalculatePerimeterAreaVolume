using System;

namespace Lab_Number_2
{
  class Program
  {
    static void Main(string[] args)
    {
      char doAgain;
      bool repeat1 = true;

      //Welcome user.
      Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
      {
        while (repeat1 == true)
        {
          //Prompt user to enter height, length, width, area, perimeter.
          Console.WriteLine("Enter Height: ");

          string height = Console.ReadLine();

          //Convert the string into an double.
          double userHeight = Convert.ToDouble(height);

          Console.WriteLine("Enter Length: ");

          string len = Console.ReadLine();

          double userLength = Convert.ToDouble(len);

          Console.WriteLine("Enter Width: ");

          string wid = Console.ReadLine();

          double userWidth = Convert.ToDouble(wid);

          Console.WriteLine("Area: " + (userLength * userWidth));
          Console.WriteLine("Perimeter: " + ((userLength * 2) + (userWidth * 2)));
          Console.WriteLine("Volume: " + (userLength * userWidth * userHeight));

          //User acknowledge results.
          Console.WriteLine("Continue? Y/N");
          doAgain = Convert.ToChar(Console.ReadLine());

          if (doAgain == 'y' || doAgain == 'Y')
          {
            repeat1 = true;
          }
          else
          {
            repeat1 = false;
          }
        }
      }
    }
  }
}

