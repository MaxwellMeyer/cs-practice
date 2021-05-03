// using System;

// class DoubleIt
// {
//   static void Main()
//   {
//     Console.WriteLine("Give me a number, and I will double it for you!");
//     string stringNumber = Console.ReadLine();  // <-- New code
//     int yourNumber = int.Parse(stringNumber);  // <-- New code
//     int yourDoubledNumber = yourNumber * 2;
//     string stringDoubledNumber = yourDoubledNumber.ToString();  // <-- New code
//     Console.WriteLine("I doubled your number for you: " + stringDoubledNumber);
//   }
// }

  using System;

class HotelCost
{
  static void Main()
  {
    Console.WriteLine("In what season are you booking a stay?");
    string season = Console.ReadLine();

    Console.WriteLine("On the weekend or a weeknight?");
    string dayOfWeek = Console.ReadLine();

    bool summer = season == "summer";
    bool weekend = dayOfWeek == "weekend";

    if (summer && weekend)
    {
      Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
    }
    else if (summer)
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
    else if (weekend)
    {
      Console.WriteLine("Your stay might be more expensive than normal!");
    }
    else
    {
      Console.WriteLine("Your stay might be expensive, but it could be worse!");
    }
  }
}