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
//############# BRANCHING#######################
// using System;

// class HotelCost
// {
//   static void Main()
//   {
//     Console.WriteLine("In what season are you booking a stay?");
//     string season = Console.ReadLine();

//     Console.WriteLine("On the weekend or a weeknight?");
//     string dayOfWeek = Console.ReadLine();

//     bool summer = season == "summer";
//     bool weekend = dayOfWeek == "weekend";

//     if (summer && weekend)
//     {
//       Console.WriteLine("Your stay is probably going to be pretty expensive. It's both peak travel season AND the weekend.");
//     }
//     else if (summer || weekend)
//     {
//       Console.WriteLine("Your stay might be more expensive than normal!");
//     }
//     else
//     {
//       Console.WriteLine("Your stay might be expensive, but it could be worse!");
//     }
//   }
// }
// %%%%%%%%%%%%%%%%%%%% PHONEBOOK %%%%%%%%%%%%%%%%%%%%
// using System;
// using System.Collections.Generic;

// class Phonebook
// {
//   public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

//   static void Main()
// {
//   Console.WriteLine("MAIN MENU");
//   Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
//   string answer = Console.ReadLine();
//   if (answer == "Y" || answer == "y")
//   {
//     AddContact();
//   }
//   else
//   {
//     Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for yes, 'Enter' for no]");
//     string lookUpAnswer = Console.ReadLine();
//     if (lookUpAnswer == "Y" || lookUpAnswer == "y")
//     {
//       LookUpContact();
//     }
//     else
//     {
//       Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
//       string finishedAnswer = Console.ReadLine();
//       if (finishedAnswer == "Y" || finishedAnswer == "y")
//       {
//         Console.WriteLine("Goodbye.");
//       }
//       else
//       {
//         Main();
//       }
//     }
//   }
// }

//   static void AddContact()
// {
//   Console.WriteLine("NEW CONTACT");
//   Console.WriteLine("Enter a new contact name");
//   string name = Console.ReadLine();
//   Console.WriteLine("Enter a new contact phone number");
//   string number = Console.ReadLine();
//   if (phoneNumbers.ContainsKey(name))
//   {
//     Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
//   }
//   else
//   {
//     phoneNumbers.Add(name, number);
//   }
//   Main();
// }


// static void LookUpContact()
// {
//   Console.WriteLine("CONTACT LOOKUP");
//   Console.WriteLine("Whose number would you like to look up?");
//   string friend = Console.ReadLine();
//   if (phoneNumbers.ContainsKey(friend))
//   {
//     string value = phoneNumbers[friend];
//     Console.WriteLine(friend + "\'s phone number is " + value);
//   }
//   else
//   {
//     Console.WriteLine("That person is not in your phone book.");
//   }
//   Main();
//   }
// }
//^^^^^^^^^^^^^^^^^^^^^^^ GROCERY LIST ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// using System;

// class GroceryList
// {
//   static void Main()
//   {
//     string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice" };

//     Console.WriteLine("My grocery list:");
//     for (int index = 0; index < myGroceryList.Length; index++)
//     {
//       Console.WriteLine(myGroceryList[index]);
//     }
//   }
// }
// ?????????????????????????????????? LEAP CHECKER ?????????????????????????????
// using System;

// class LeapYear
// {
//   static void Main()
//   {
//     Console.WriteLine("What year were you born in?");
//     string stringBirthYear = Console.ReadLine();
//     int birthYear = int.Parse(stringBirthYear);

//     Console.WriteLine("You were alive during these leap years:");
//     for (int year = birthYear; year <= 2020; year ++)
//     {
//       if (year % 4 == 0)
//       {
//         Console.WriteLine(year);
//       }
//     }
//   }
// }
//@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ DEARLERSHIP @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car volkswagen = new Car();
    volkswagen.MakeModel = "1974 Volkswagen Thing";
    volkswagen.Price = 1100;
    volkswagen.Miles = 368792;

    Car yugo = new Car();
    yugo.MakeModel = "1980 Yugo Koral";
    yugo.Price = 700;
    yugo.Miles = 56000;

    Car ford = new Car();
    ford.MakeModel = "1988 Ford Country Squire";
    ford.Price = 1400;
    ford.Miles = 239001;

    Car amc = new Car();
    amc.MakeModel = "1976 AMC Pacer";
    amc.Price = 400;
    amc.Miles = 198000;

    List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice))
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}