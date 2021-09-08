using System;

namespace BSDA21
{

public class LeapYear {

    bool isLeapYearBool;

public void IsLeapYear (int year) {
    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) {
        isLeapYearBool = true;
    }
    Console.WriteLine(isLeapYearBool ? "yay" : "nay");  
    }
    
public static void Main(string[] args) {
    LeapYear LY = new LeapYear(); 
    int year = int.Parse(Console.ReadLine());   
    LY.IsLeapYear(year);
}
}
}
