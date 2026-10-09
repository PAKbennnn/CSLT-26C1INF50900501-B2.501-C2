using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_26C1INF50900501_B2._501_C2.buoi9
{
    internal class baitapchuoi
    {
        static string Print()
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            return str;
        }
        static string Substring()
        {
            Console.WriteLine("Enter a substring");
            string str = Console.ReadLine();
            return str;
        }
        static int CountLength(string str)
        {
            int count = 0;
            foreach (char c in str)
                count++;
            return count;
        }
        static void Seperate(string str)
        {
            foreach (char c in str)
                Console.WriteLine(c);
        }
        static void SeperateReverse(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
                Console.WriteLine(str[i]);
        }
        static int CountWords(string str)
        {
            str = str.Trim();
            bool x = false;
            string str1 = "";
            foreach (char c in str)
            {
                if (x == false || char.IsLetter(c))
                    str1 += c;
                if (c == ' ')
                    x = true;
                else x = false;
            }
            str1 = str1.Trim();
            string[] words = str1.Split(' ');
            return words.Length;
        }
        static void CompareString(string str1, string str2)
        {
            if (str1 == str2)
                Console.WriteLine("2 strings are equal");
            else
                Console.WriteLine("2 strings are not equal");
        }
        static int[] CountAlphabetDigitSpecialCharacters(string str)
        {
            int countAlphabet = 0;
            int countDigit = 0;
            int countSpecialChar = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                    countAlphabet++;
                else if (char.IsDigit(c))
                    countDigit++;
                else
                    countSpecialChar++;
            }
            int[] a = { countAlphabet, countDigit, countSpecialChar };
            return a;
        }
        static int[] CountVowels(string str)
        {
            int countvowel = 0;
            int countnotvowel = 0;
            foreach (char c in str)
            {
                if ("aeiouAEIOU".IndexOf(c) >= 0)
                    countvowel++;
                else
                    countnotvowel++;
            }
            int[] a = { countvowel, countnotvowel };
            return a;
        }
        static bool CheckSubstring(string str, string substring)
        {
            return str.Contains(substring);
        }
        static void CheckAlphabetCheckCase(string str)
        {
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                        Console.WriteLine($"{c} is an uppercase letter.");
                    else
                        Console.WriteLine($"{c} is a lowercase letter.");
                }
                else
                {
                    Console.WriteLine($"{c} is not an alphabetic character.");
                }
            }
        }
        static int[] SearchPosition(string str, int time, string substring)
        {
            int[] a = new int[time];
            int dem = 0;
            for (int i = 0; i <= str.Length - substring.Length; i++)
            {
                if (str[i] == substring[0])
                {
                    string temp = str.Substring(i, substring.Length);
                    if (temp == substring)
                    {
                        a[dem] = i + 1;
                        dem++;
                    }
                }
            }
            return a;

        }
        static int CountTimeOfSubstring(string str, string substring)
        {
            int count = 0;
            int count1 = 0;
            while (str.Length - count - substring.Length >= 0)
            {
                if (substring == str.Substring(count, substring.Length))
                {
                    count1++;
                }
                count++;
            }
            return count1;
        }
        static void InsertString(string str, string insertedString, int[] posittion)
        {
            for (int i = 0; i < posittion.Length; i++)
            {
                str = str.Insert(posittion[i] - 1, insertedString);
            }
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            string str = Print();
            Console.WriteLine(str);
            int length = CountLength(str);
            Console.WriteLine("length of string = " + length);
            Seperate(str);


            Console.WriteLine();


            SeperateReverse(str);

            Console.WriteLine();

            int countword = CountWords(str);
            Console.WriteLine(countword);

            string str1 = Print();

            CompareString(str1, str);

            Console.WriteLine();

            int[] everythingCounts = CountAlphabetDigitSpecialCharacters(str);
            Console.WriteLine("Number of alphabets: " + everythingCounts[0]);
            Console.WriteLine("Number of digits: " + everythingCounts[1]);
            Console.WriteLine("Number of special characters: " + everythingCounts[2]);

            int[] vowelandnotCounts = CountVowels(str);
            Console.WriteLine("Number of vowels: " + vowelandnotCounts[0]);
            Console.WriteLine("Number of non-vowels: " + vowelandnotCounts[1]);

            string substring = Substring();
            bool check = CheckSubstring(str, substring);
            Console.WriteLine(check);

            int time = CountTimeOfSubstring(str, substring);
            Console.WriteLine($"Time = {time}");

            int[] position = SearchPosition(str, time, substring);
            for (int i = 0; i < position.Length; i++)
            {
                Console.WriteLine($"Position {i + 1} = {position[i]}");
            }

            CheckAlphabetCheckCase(str);


            Console.WriteLine("Enter string to insert:");
            string insertedString = Console.ReadLine();

            InsertString(str, insertedString, position);
        }
    }
}
