using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int result = LongestPalindrome(text);
        Console.WriteLine(result);
    }

    static int LongestPalindrome(string temp)
    {
        int n = temp.Length;
        int maxLen = 1;
        int start = 0;

        for (int j = 0; j < n; j++)
        {
            for (int k = j; k < n; k++)
            {
                if (checkPalindrome(temp, j, k) && (k - j + 1) > maxLen)
                {
                    start = j;
                    maxLen = k - j + 1;
                }
            }
        }

        string longestInCurrent = temp.Substring(start, maxLen);

        return longestInCurrent.Length;
    }

    static bool checkPalindrome(string text, int start, int end)
    {
        while (start < end)
        {
            if (text[start] != text[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}