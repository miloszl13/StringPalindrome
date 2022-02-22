using NUnit.Framework;

namespace StringPalindrome.Tests
{
    public class PalindromeCheckerTests
    {
        private PalindromeChecker _checker { get; set; } = null;

        [SetUp]
        public void Setup()
        {
          _checker = new PalindromeChecker();
        }

        [Test]
        public void Check_Palindrome_ReturnTrue()
        {
            //Assing
            string word = "anavolimilovana";
            //Act
            bool isPalindrome = _checker.Check(word);
            //Assert
            Assert.AreEqual(true, isPalindrome);
        }
        [Test]
        public void Check_NotPalindrome_False()
        {
            //Assing
            string word = "awwagwgwgghhaeae";
            //Act
            bool isPalindrome = _checker.Check(word);
            //Assert
            Assert.AreEqual(false, isPalindrome);
        }
    }
}