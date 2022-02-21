Console.WriteLine("Insert some word:");
var word = Console.ReadLine().ToLower(); ;

bool isPalindrome = false;

for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
{
    if (word[i] != word[j])
    {
        isPalindrome = false;
        break;
    }
    else
    {
        isPalindrome = true;
    }
}
Console.WriteLine($"{isPalindrome}");