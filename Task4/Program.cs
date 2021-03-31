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

            // char[] reverse = word.ToCharArray();
            // Array.Reverse(reverse);
            // string reversedWord = new string(reverse);


            //if (Equals(word, reversedWord))
            //{
            //    Console.WriteLine("Entered word is palindrome");
            //}

            //else
            //{
            //    Console.WriteLine("Entered word is NOT palindrome");
            //}

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




//foreach (char ch1 in converWordtoArray)
//{
//    foreach (char ch2 in reverse)
//    {
//        if (ch1 == ch2)
//        {
//            Console.WriteLine("Entered word is palindrome");
//        }

//        else
//        {
//            Console.WriteLine("Entered word is NOT palindrome");
//        }
//    }
//}

//    if (converWordtoArray.Length == reverse.Length)
//{
//    Console.WriteLine("Entered word is palindrome");
//}

//else
//{
//    Console.WriteLine("Entered word is NOT palindrome");
//}
//foreach (char ch in converWordtoArray)
//{
//    if (word == reverse)
//    Console.WriteLine(ch);
//}

//    if (word.Equals(reverse))
//{
//    Console.WriteLine("Entered word is palindrome");
//}
//else
//{
//    Console.WriteLine("Entered word is NOT palindrome");
//}


