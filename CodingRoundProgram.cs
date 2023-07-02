//Write a program to check if a string or integer is palindrome or not?
class palindrome {
      static void Main(string[] args) {
         string string1, rev;
         string1 = "Zeeshan";
         char[] ch = string1.ToCharArray();
         Array.Reverse(ch);
         rev = new string(ch);
         bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
         if (b == true) {
            Console.WriteLine("" + string1 + " is a Palindrome!");
         } else {
            Console.WriteLine(" " + string1 + " is not a Palindrome!");
         }
         Console.Read();
      }
//---------------------------------------------------
  //Write a code to reverse a number
  public static void Main(string[] args)
    {
        int number = 1234;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        Console.WriteLine("The reversed number is: {0}", reversedNumber);
    }

  //--------------------------
  //Write the code to find the Fibonacci series upto the nth term.
  //
//The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding numbers. 
//The sequence starts with 0 and 1, and then continues with 1, 2, 3, 5, 8, 13, 21, 34, and so on.

  public class FibonacciSeries
{
    public static void Main(string[] args)
    {
        int n = 10;
        int firstTerm = 0;
        int secondTerm = 1;
        int nextTerm = 0;

        Console.WriteLine("The Fibonacci series upto {0} terms is: ", n);

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write("{0}, ", firstTerm);
            }
            else if (i == 2)
            {
                Console.Write("{0}, ", secondTerm);
            }
            else
            {
                nextTerm = firstTerm + secondTerm;
                Console.Write("{0}, ", nextTerm);

                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}


//Write code of Greatest Common Divisor 
//For example, if you have 10 cookies and 15 cookies, you can keep taking one cookie from the 15 cookies and giving it to the 10 cookies until you have 5 cookies left.
  //The last cookie you took from the 15 cookies is 5, which is the greatest common divisor of 10 and 15.

//Here is a more detailed explanation of the algorithm:

//Start with two numbers, a and b.
//Keep taking the remainder of a when divided by b and storing it in a new variable, r.
//If r is 0, then b is the greatest common divisor of a and b. Otherwise, set a to b and b to r and go back to step 2.
  public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = a;
            a = b;
            b = temp % b;
        }

        return a;
    }



//
//Write code of  Perfect number

//A perfect number is a positive integer that is equal to the sum of its proper divisors. 
//proper divisor of a number is a divisor that is smaller than the number itself. 
//For example, 6 is a perfect number because its proper divisors are 1, 2, and 3, and their sum is 6.


  public static bool IsPerfectNumber(int number)
    {
        int sumOfProperDivisors = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sumOfProperDivisors += i;
            }
        }

        return sumOfProperDivisors == number;
    }
//Complexity - O(n)



//Write code to Check if two strings are Anagram or not
//An anagram is a word or phrase formed by rearranging the letters of another word or phrase. For example, "cat" and "tac" are anagrams.
//

  public static bool areAnagram(ArrayList str1,
                                  ArrayList str2)
    {
        // Get lengths of both strings
        int n1 = str1.Count;
        int n2 = str2.Count;
 
        // If length of both strings is not
        // same, then they cannot be anagram
        if (n1 != n2) {
            return false;
        }
 
        // Sort both strings
        str1.Sort();
        str2.Sort();
 
        // Compare sorted strings
        for (int i = 0; i < n1; i++) {
            if (str1[i] != str2[i]) {
                return false;
            }
        }
 
        return true;
    }
  
