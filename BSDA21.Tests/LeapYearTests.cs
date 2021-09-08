using System;
using System.IO;
using Xunit;

namespace BSDA21.Tests
{

    public class UnitTest1
    {
        [Fact]
        public void Checks_If_Divisible_By_Four()
        {
            LeapYear LY = new LeapYear();
            var actual = LY.isDivisibleByFour(2000);
            
            Assert.True(actual);
        }
    }

    public class UnitTest2
    {
        [Fact]
        public void IsLeapYear()
        {
            LeapYear LY = new LeapYear();
            var actual = LY.IsLeapYear(1600);
            
            Assert.True(actual);
        }
    }

    public class UnitTest3 
    {
        [Fact]
        public void PrintsYayIfUserInputIsLeapYear() {
            LeapYear LY = new LeapYear();
            var year = int.Parse(Console.ReadLine());
            
            var writer = new StringWriter();
            Console.SetOut(writer);
            LY.IsLeapYear(year);
            
            var actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal("yay", actual);
        }
    }
}

