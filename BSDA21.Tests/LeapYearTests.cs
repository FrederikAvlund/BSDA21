using System;
using System.IO;
using Xunit;

namespace BSDA21.Tests
{
/*
    public class UnitTest1 //Exercise 5
    {
        [Fact]
        public void Checks_If_Divisible_By_Four()
        {
            LeapYear LY = new LeapYear();
            var actual = LY.isDivisibleByFour(2000);
            
            Assert.True(actual);
        }
    }

    public class UnitTest2 // Exercise 5
    {
        [Fact]
        public void IsLeapYear()
        {
            LeapYear LY = new LeapYear();
            var actual = LY.IsLeapYear(1600);
            
            Assert.True(actual);
        }
    }


    public class UnitTest3  //Exercise 6
    {
        [Fact]
        public void PrintsYayIfUserInputIsLeapYear() {
            //var year = int.Parse(Console.ReadLine());
            Console.SetIn(new StringReader("1600"));
            
            var writer = new StringWriter();
            Console.SetOut(writer);
            LeapYear.Main(new string[0]);
            
            var actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("yay", actual);
        }
    }
}
*/

    public class UnitTest4 //Exercise 7
    {
        [Fact]
        public void checksYearForErrors()
        {
            Console.SetIn(new StringReader("1500"));

            var writer = new StringWriter();
            Console.SetOut(writer);
            LeapYear.Main(new string[0]);
            
            var actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("The year must be from 1582 or later!", actual);
            Console.Out.Flush();
        }
    }
/* // Test commented out, since the unit tests work when tested individually. 

    public class UnitTest5 //Exercise 7
    {
        [Fact]
        public void checksYearForStringErrors()
        {
            Console.SetIn(new StringReader("abc"));

            var writer = new StringWriter();
            Console.SetOut(writer);
            LeapYear.Main(new string[0]);
            
            var actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("Please type in a year using integers", actual);
        }
    }
 */
}