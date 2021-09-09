using System;

namespace BSDA21
{

public class LeapYear {

    bool isLeapYearBool;

public void IsLeapYear (int year) {
     if (year < 1582) {
        throw new ArgumentException("The year must be from 1582 or later!");
    }
    else {
    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
        isLeapYearBool = true;
    }
    Console.WriteLine(isLeapYearBool ? "yay" : "nay");  
    }
}

    
public static void Main(string[] args) {
    LeapYear LY = new LeapYear();
    try {
    int year = int.Parse(Console.ReadLine());    
    LY.IsLeapYear(year);
    }
    catch (ArgumentException e) {
        Console.WriteLine(e.Message);
    }
    catch (FormatException) {
        Console.WriteLine("Please type in a year using integers");
    }
    }
}
}
