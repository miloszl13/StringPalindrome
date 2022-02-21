

using StringPalindrome;

var word = new UserInput().AskForWord();

var checker = new InputChecker(new PalindromeChecker());
var isPalindrome = checker.Check(word);

Console.WriteLine($"{isPalindrome}");
