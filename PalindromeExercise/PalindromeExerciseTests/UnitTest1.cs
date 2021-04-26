using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("", true)]
        [InlineData("starts", false)]
        [InlineData(null, false)]
        public void IsAPalindromeTest(string str, bool expected)
        {
            var ws = new PalindromeExercise.WordSmith();

            var actual = ws.IsAPalindrome(str);

            Assert.Equal(expected, actual);
        }
    }
}
