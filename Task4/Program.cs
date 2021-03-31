using System;

namespace Task4
{
    class Program
    {
 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            string word1 = Console.ReadLine();
            string convertToUpper = word1.ToUpper();
            Console.WriteLine(CompareEnteredWordAndReversedWord(convertToUpper));

        }

        public static string ReverseWord(string word)
        {

            char[] reverse = word.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }

        public static string CompareEnteredWordAndReversedWord(string enteredWord)
      
        {
            string reversedWord = ReverseWord(enteredWord);
            if (Equals(enteredWord, reversedWord))
            {
                return "Entered word is palindrome";
            }
            else
            
            {
                return "Entered word is NOT palindrome";
            }
        }
    }

}


