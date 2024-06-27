//1
Console.WriteLine("Введите слово из строчных букв:");
string word = Console.ReadLine().ToLower(); // Приводим слово к нижнему регистру для удобства сравнения

bool isPalindrome = IsPalindrome(word);

if (isPalindrome)
{
    Console.WriteLine("Is a palindrom");
}
else
{
    Console.WriteLine("Not a palindrom");
}
    
 static bool IsPalindrome(string word)
 {
  int left = 0;
  int right = word.Length - 1;

    while (left < right)
    {
        if (word[left] != word[right])
        {
            return false; // Не является палиндромом
        }

        left++;
        right--;
    }

   return true; // Является палиндромом
 }

//2
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Нечетные числа от 1 до " + number + ":");
PrintOddNumbersRecursive(1, number);
    

    static void PrintOddNumbersRecursive(int start, int end)
{
    if (start < end)
    {
        if (start % 2 != 0)
        {
            Console.WriteLine(start);
        }
        PrintOddNumbersRecursive(start + 1, end);
    }
}