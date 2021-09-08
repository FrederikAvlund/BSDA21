using System;

namespace BSDA21
{

public class LeapYear {

    bool isLeapYearBool;

public bool isDivisibleByFour(int year) {
    if (year % 4 == 0) {
        isLeapYearBool = true;
    }
    return isLeapYearBool;
}

public bool IsLeapYear (int year) {
    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
        isLeapYearBool = true;
    }
    return isLeapYearBool;
}

public static void Main(string[] args) {
    LeapYear LY = new LeapYear(); 
    Console.WriteLine(LY.IsLeapYear(2000));
}
}
}
